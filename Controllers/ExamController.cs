using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExaminationSystem.Data;
using ExaminationSystem.DTOs.Exam;
using ExaminationSystem.Helpers;
using ExaminationSystem.Mediators.Exam;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;
using ExaminationSystem.Services.Exams;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Exam;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ExamController : ControllerBase
    {
        IExamService _examService;
        IExamMediator _examMediator;
        
        public ExamController(IExamService examService)
        {
            _examService = examService;
        }


        [HttpGet]
        public ResultViewModel<IEnumerable<ExamViewModel>> GetAll() {
            var exams = _examService.GetAll()
             .Select(x => x.MapOne<ExamViewModel>());

            //return _examService.GetAll()
            //        .AsQueryable()
            //        .ProjectTo<ExamViewModel>(_mapper.ConfigurationProvider);

            return new ResultViewModel<IEnumerable<ExamViewModel>>
            {
                IsSuccess = true,
                Data = exams,
                Message = ""
            };
        }

        [HttpGet]
        public ResultViewModel<ExamViewModel> GetById(int id)
        {
            var exam = _examService.GetById(id);

            var examViewModel = exam.MapOne<ExamViewModel>();

            return ResultViewModel<ExamViewModel>.Success(examViewModel);
        }

        [HttpPost]
        public ResultViewModel<bool> Post(ExamCreateViewModel viewModel)
        {
            var exam = viewModel.MapOne<ExamCreateDTO>();
            _examService.Add(exam);


            //_context.savechanges();

            return new ResultViewModel<bool>
            {
                IsSuccess = true,
                Data = true,
                Message = ""
            };
        }
    }
}
