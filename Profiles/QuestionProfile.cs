using AutoMapper;
using ExaminationSystem.DTOs.Question;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Exam;

namespace ExaminationSystem.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<QuestionCreateViewModel,Question>().ReverseMap();
            CreateMap<QuestionCreateViewModel, QuestionCreateDTO>().ReverseMap();
            CreateMap<QuestionCreateDTO, Question>().ReverseMap();


        }
    }
}
