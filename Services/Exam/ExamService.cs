using AutoMapper;
using AutoMapper.QueryableExtensions;
using ExaminationSystem.Data;
using ExaminationSystem.DTOs.Exam;
using ExaminationSystem.Exceptions;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Services.Exams
{
    public class ExamService : IExamService
    {
        IRepository<Exam> _repository;
        IExamQuestionService examQuestionService;

        public ExamService(IRepository<Exam> repository, IExamQuestionService examQuestionService)
        {
            _repository = repository;
            this.examQuestionService = examQuestionService;
        }
        public int Add(ExamCreateDTO examDTO)
        {
            var exam = examDTO.MapOne<Exam>();

            _repository.Add(exam);

            try
            {
                _repository.SaveChanges();
            }
            catch (DbUpdateConcurrencyException ex)
            {
                ex.Entries.First();
                throw;
            }

            examQuestionService.AddRange(exam.ID, examDTO.QuestionsIDs);

            return exam.ID;
        }

        public IEnumerable<ExamDTO> GetAll()
        {
            var exams = _repository.GetAll();

            return exams.Map<ExamDTO>();
        }

        public ExamDTO GetById(int id)
        {
            var exam = _repository.GetWithTrackinByID(id);

            return exam.MapOne<ExamDTO>();
        }

        private bool ValidateExam(ExamCreateDTO examCreateDTO)
        {
            if (examCreateDTO.StartDate > DateTime.Now) return true;

            throw new BusinessException(ErrorCodes.NotValidExamDate, "Start Date must be in future");
        }
    }
}
