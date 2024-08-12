using AutoMapper;
using ExaminationSystem.DTOs.Courses;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Courses;

namespace ExaminationSystem.Profiles
{
    public class CourseProfile : Profile
    {
        public CourseProfile()
        {
            CreateMap<CourseCreateViewModel,CourseCreateDTO>().ReverseMap();
            CreateMap<Course,CourseCreateDTO>().ReverseMap();
        }
    }
}
