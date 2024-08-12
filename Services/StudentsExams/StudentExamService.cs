using ExaminationSystem.Models;
using ExaminationSystem.Repositories;
using ExaminationSystem.ViewModels.StudentsExams;

namespace ExaminationSystem.Services.StudentsExams
{
    public class StudentExamService : IStudentsExamsService
    {
        IRepository<StudentExam> _repository;

        public StudentExamService(IRepository<StudentExam> repository)
        {
            _repository = repository;
        }

        public void Add(StudentExamCreateViewModel studentExamCreateViewModel)
        {
            var Student = _repository.Add(new StudentExam
            {
                ExamId = studentExamCreateViewModel.ExamId,
                StudentId = studentExamCreateViewModel.StudentId,
                Result = studentExamCreateViewModel.Result
            });

            _repository.SaveChanges();
        }

        public void AddRange(int examID, IEnumerable<int> StudentsIDs)
        {
            throw new NotImplementedException();
        }
    }
}
