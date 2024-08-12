using ExaminationSystem.DTOs.Choice;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;

namespace ExaminationSystem.Services.Choices
{
    public class ChoiceService : IChoiceService
    {
        IRepository<Choice> _choicesRepository;

        public ChoiceService(IRepository<Choice> choicesRepository)
        {
            _choicesRepository = choicesRepository;
        }

        public int AddChoice(ChoiceCreateDTO choiceDTO)
        {
            var choice = choiceDTO.MapOne<Choice>();

            _choicesRepository.Add(choice);

            _choicesRepository.SaveChanges();

            return choice.ID;
        }

        public void AddRange(int QuestionId, IEnumerable<ChoiceCreateDTO> ChoicesIds)
        {
            foreach (var item in ChoicesIds)
            {
                //_choicesRepository.MapOne<Choice>();
                _choicesRepository.Add(new Choice
                {
                    Text = item.Text,
                    IsRightAnswer = item.IsRightAnswer,
                    QuestionsId = QuestionId,
                });

            }
                //_choicesRepository.SaveChanges();
        }
    }
}
