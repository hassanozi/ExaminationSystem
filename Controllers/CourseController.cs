using ExaminationSystem.Data;
using ExaminationSystem.DTOs.Courses;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Services.Courses;
using ExaminationSystem.ViewModels;
using ExaminationSystem.ViewModels.Courses;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace ExaminationSystem.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class CourseController : ControllerBase
    {
        private readonly ICoursesService _coursesService;

        public CourseController(ICoursesService coursesService)
        {
            _coursesService = coursesService;
        }

        [HttpGet]
        public IEnumerable<CourseCreateViewModel> GetAll()
        {
           var courses = _coursesService.GetAllCourses();

            return courses.Select(x => x.MapOne<CourseCreateViewModel>());
        }

        [HttpPost]
        public bool Post(CourseCreateViewModel courseCreateViewModel) 
        {
            var course = courseCreateViewModel.MapOne<CourseCreateDTO>();

            _coursesService.AddCourse(course);

            return true;
        }


        //[HttpGet]
        //public Course GetByID(int id)
        //{
        //    Context context = new Context();

        //    Course qst = _context.Courses.Where(x => x.ID == id)
        //        .Include(c => c.Instructor)
        //        .Include(c => c.Exams)
        //        .ThenInclude(ex => ex.ExamQuestions)
        //        .FirstOrDefault();

        //    return qst;
        //}



    }
}
