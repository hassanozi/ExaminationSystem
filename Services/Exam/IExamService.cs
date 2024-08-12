using ExaminationSystem.DTOs.Exam;
using ExaminationSystem.ViewModels.Exam;

namespace ExaminationSystem.Services.Exams
{
    public interface IExamService
    {
        int Add(ExamCreateDTO examDTO);
        IEnumerable<ExamDTO> GetAll();
        ExamDTO GetById(int id);
    }
}
