using Project_Api_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Api_BLL.Service
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> GetAllStudents();
        Task<Student> GetStudentById(int id);
        Task<Student> GetStudentByPhone(string phone);
        Task AddStudent(Student student);
        Task UpdateStudent(Student student);
        Task DeleteStudent(int id);
    }
}
