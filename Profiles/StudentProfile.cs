using AutoMapper;
using ExaminationSystem.DTOs.Student;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Students;

namespace ExaminationSystem.Profiles
{
    public class StudentProfile : Profile
    {
        public StudentProfile() 
        { 
            CreateMap<StudentCreateViewModel,StudentCreateDTO>().ReverseMap();
            CreateMap<StudentCreateViewModel,Student>().ReverseMap();
            CreateMap<StudentCreateDTO,Student>().ReverseMap();

        }
    }
}
