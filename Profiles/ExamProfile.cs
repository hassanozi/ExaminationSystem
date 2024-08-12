using AutoMapper;
using ExaminationSystem.DTOs.Exam;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Exam;

namespace ExaminationSystem.Profiles
{
    public class ExamProfile : Profile
    {
        public ExamProfile()
        {
            CreateMap<ExamCreateViewModel, ExamCreateDTO>();
            CreateMap<ExamCreateDTO, Exam>();
            CreateMap<Exam, ExamDTO>()
                .ForMember(dst => dst.ExamId, opt => opt.MapFrom(src => src.ID))
                .ForMember(dst => dst.NumberOfQuestions, opt => opt.MapFrom(src => src.ExamQuestions.Count));
            CreateMap<ExamDTO, ExamViewModel>();
        }
    }
}
