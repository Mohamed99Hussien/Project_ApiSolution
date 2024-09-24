using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Api_DAL.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Grade { get; set; }

        
        public ICollection<Course> Courses { get; set; }
    }
}
