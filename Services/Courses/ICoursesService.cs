using ExaminationSystem.DTOs.Courses;
using ExaminationSystem.Models;
using ExaminationSystem.ViewModels.Courses;

namespace ExaminationSystem.Services.Courses
{
    public interface ICoursesService
    {
        IEnumerable<CourseCreateDTO> GetAllCourses();
        void AddCourse(CourseCreateDTO courseCreateDTO);
        void UpdateCourse(CourseUpdateViewModel  courseUpdateViewModel);
        void DeleteCourse(int id);
    }
}
