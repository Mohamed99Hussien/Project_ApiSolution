using AutoMapper;
using Project_Api_BLL.DTOs;
using Project_Api_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Api_BLL.Helper
{
    public class MappingProfile : Profile
    {   
        public MappingProfile()
        {
            CreateMap<Student, StudentDto>().ReverseMap();
            CreateMap<Course, CourseDto>().ReverseMap();
        }
    }

}
