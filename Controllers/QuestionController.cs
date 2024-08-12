using ExaminationSystem.Data;
using ExaminationSystem.DTOs.Question;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Services.Questions;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Exam;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class QuestionController : ControllerBase
    {
        private readonly QuestionService _questionService;

        public QuestionController(QuestionService questionService)
        {
            _questionService = questionService;
        }
                
        [HttpGet]
        public QuestionCreateViewModel GetByID(int id)
        {

            var qst = _questionService.GetQuestion(id);

            return qst.MapOne<QuestionCreateViewModel>();
        }

        [HttpGet]
        public IEnumerable<QuestionCreateViewModel> GetQuestions()
        {
            var exams = _questionService.GetAllQuestions();

            return exams.Select(x => x.MapOne<QuestionCreateViewModel>());
        }


        [HttpPost]
        public bool Post(QuestionCreateViewModel questionCreateViewModel)
        {
            var question = questionCreateViewModel.MapOne<QuestionCreateDTO>();

            _questionService.AddQuestion(question);

            return true;
        }
    }
}
