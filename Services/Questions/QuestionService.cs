using ExaminationSystem.DTOs.Question;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;
using ExaminationSystem.Services.Choices;
using ExaminationSystem.ViewModels.Exam;

namespace ExaminationSystem.Services.Questions
{
    public class QuestionService : IQuestionsService
    {
        IRepository<Question> _questionsRepository;
        IChoiceService _choiceService;

        public QuestionService(IRepository<Question> questionsRepository, IChoiceService choiceService)
        {
            _questionsRepository = questionsRepository;
            _choiceService = choiceService;
        }

        public IEnumerable<QuestionCreateDTO> GetAllQuestions()
        {
            var questions = _questionsRepository.GetAll();

            return questions.Map<QuestionCreateDTO>();
        }

        public QuestionCreateDTO GetQuestion(int id)
        {
            var question = _questionsRepository.GetWithTrackinByID(id);

            return question.MapOne<QuestionCreateDTO>();
        }
        public void AddQuestion(QuestionCreateDTO  questionCreateDTO)
        {
            var question = questionCreateDTO.MapOne<Question>();

            _questionsRepository.Add(question);

            _choiceService.AddRange(question.ID, questionCreateDTO.ChoicesDetails);
        }

        //public void AddRange(int QuestionId, IEnumerable<int> ChoicesIds) 
        //{
        //    foreach (var item in ChoicesIds)
        //    {
        //        //_choicesRepository.MapOne<Choice>();
        //        _choicesRepository.Add(new Choice
        //        {
        //            ID = item,
        //            QuestionsId = QuestionId,
        //        });

        //        _choicesRepository.SaveChanges();
        //    }
        //}
    }
}
