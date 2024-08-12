using ExaminationSystem.DTOs.Student;
using ExaminationSystem.ViewModels.Students;

namespace ExaminationSystem.Services.Students
{
    public interface IStudentService
    {
        void AddStudent(StudentCreateDTO studentCreateViewModel);
        void update(StudentUpdateViewModel studentUpdateViewModel);
        void Delete(int id);
    }
}
