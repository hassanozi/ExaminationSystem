using ExaminationSystem.ViewModels.StudentsExams;

namespace ExaminationSystem.Services.StudentsExams
{
    public interface IStudentsExamsService
    {
        void Add(StudentExamCreateViewModel studentExamCreateViewModel);
        void AddRange(int examID, IEnumerable<int> StudentsIDs);
    }
}
