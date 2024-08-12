using ExaminationSystem.DTOs.Choice;

namespace ExaminationSystem.Services.Choices
{
    public interface IChoiceService
    {
        int AddChoice(ChoiceCreateDTO choiceDTO);
        void AddRange(int QuestionId, IEnumerable<ChoiceCreateDTO> ChoicesIds);
    }
}
