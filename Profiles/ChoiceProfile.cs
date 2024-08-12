using AutoMapper;
using ExaminationSystem.DTOs.Choice;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Choices;

namespace ExaminationSystem.Profiles
{
    public class ChoiceProfile : Profile
    {
        public ChoiceProfile() 
        {
            CreateMap<Choice, ChoicesCreateViewModel>().ReverseMap();
                //.ForMember(dst => dst.Id, opt => opt.MapFrom(src => src.ID));

            CreateMap<ChoicesCreateViewModel, ChoiceCreateDTO>().ReverseMap();
            CreateMap<ChoiceCreateDTO,Choice >().ReverseMap();

        }
    }
}
