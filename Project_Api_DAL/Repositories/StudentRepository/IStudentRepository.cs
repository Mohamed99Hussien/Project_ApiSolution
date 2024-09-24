using Project_Api_DAL.Entities;
using Project_Api_DAL.Repositories.GenericRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Api_DAL.Repositories.StudentRepository
{
    public interface IStudentRepository : IGenericRepository<Student>
    {
        Task<Student> GetStudentByPhone(string phone);
    }
}
