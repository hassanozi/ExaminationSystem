using ExaminationSystem.DTOs.Courses;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;
using ExaminationSystem.ViewModels.Courses;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem.Services.Courses
{
    public class CoursesService : ICoursesService
    {
        IRepository<Course> _coursesRepository;
        public void AddCourse(CourseCreateDTO courseCreateDTO)
        {
            var course = courseCreateDTO.MapOne<Course>();

            _coursesRepository.Add(course);

            _coursesRepository.SaveChanges();
        }

        public void DeleteCourse(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateCourse(CourseUpdateViewModel courseUpdateViewModel)
        {
            throw new NotImplementedException();
        }

        // when change to ireadonlylist  error raised why?
        public IEnumerable<CourseCreateDTO> GetAllCourses()
        {
            var courses = _coursesRepository.GetAll();

            return courses.Map<CourseCreateDTO>();
        }
    }
}
