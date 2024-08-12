using ExaminationSystem.DTOs.Exam;
using ExaminationSystem.Services.Exams;
using ExaminationSystem.Services.Instructors;

namespace ExaminationSystem.Mediators.Exam
{
    public class ExamMediator : IExamMediator
    {
        public ExamMediator(IExamService examService, IInstructorsService instructorsService, IExamQuestionService examQuestionService)
        {
        }

        public void Add(ExamCreateDTO exam)
        {
            throw new NotImplementedException();
        }
    }
}
