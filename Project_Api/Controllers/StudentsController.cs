using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Project_Api_BLL.DTOs;
using Project_Api_BLL.Service;
using Project_Api_DAL.Entities;

namespace Project_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;

        public StudentsController(IStudentService studentService, IMapper mapper)
        {
            _studentService = studentService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var students = await _studentService.GetAllStudents();
            var studentsDto = _mapper.Map<IEnumerable<StudentDto>>(students);
            return Ok(studentsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var student = await _studentService.GetStudentById(id);
            if (student == null)
                return NotFound();

            var studentDto = _mapper.Map<StudentDto>(student);
            return Ok(studentDto);
        }

        [HttpGet("by-phone/{phone}")]
        public async Task<IActionResult> GetByPhone(string phone)
        {
            var student = await _studentService.GetStudentByPhone(phone);
            if (student == null)
                return NotFound();

            var studentDto = _mapper.Map<StudentDto>(student);
            return Ok(studentDto);
        }

        [HttpPost]
        public async Task<IActionResult> Create(StudentDto studentDto)
        {
            var student = _mapper.Map<Student>(studentDto);
            await _studentService.AddStudent(student);
            return CreatedAtAction(nameof(GetById), new { id = student.Id }, studentDto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, StudentDto studentDto)
        {
            if (id != studentDto.Id)
                return BadRequest();

            var student = _mapper.Map<Student>(studentDto);
            await _studentService.UpdateStudent(student);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _studentService.DeleteStudent(id);
            return NoContent();
        }
    }

}
