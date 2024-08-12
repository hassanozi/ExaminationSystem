using AutoMapper;
using ExaminationSystem.DTOs.Instructor;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Instructors;

namespace ExaminationSystem.Profiles
{
    public class InstructorProfile : Profile
    {
        public InstructorProfile()
        {
            CreateMap<Instructor, InstructorViewModel>().ReverseMap();
            CreateMap<InstructorCreateDTO,InstructorCreateViewModel >().ReverseMap();
            CreateMap<InstructorCreateDTO,Instructor >().ReverseMap();

        }
    }
}
