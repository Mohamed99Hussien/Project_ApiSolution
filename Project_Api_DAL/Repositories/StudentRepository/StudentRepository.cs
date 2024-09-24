using Microsoft.EntityFrameworkCore;
using Project_Api_DAL.DbContexts;
using Project_Api_DAL.Entities;
using Project_Api_DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Api_DAL.Repositories.StudentRepository
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(AppDbContext context) : base(context) { }

        public async Task<Student> GetStudentByPhone(string phone)
        {
            return await _context.Students
                                 .Include(s => s.Courses) 
                                 .FirstOrDefaultAsync(s => s.Phone == phone);
        }
    }


}
