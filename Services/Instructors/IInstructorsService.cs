using ExaminationSystem.DTOs.Instructor;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Instructors;

namespace ExaminationSystem.Services.Instructors
{
    public interface IInstructorsService
    {
        IEnumerable<InstructorCreateDTO> GetAllInstructors();
        Instructor GetInstructorById(int id);
        void AddInstructor(InstructorCreateDTO instructorCreateViewModel);
        void UpdateInstructor(InstructorUpdateViewModel instructorUpdateViewModel);
        void DeleteInstructor(int id);
    }
}
