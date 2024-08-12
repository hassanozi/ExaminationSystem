using ExaminationSystem.DTOs.Student;
using ExaminationSystem.Helpers;
using ExaminationSystem.Services.Students;
using ExaminationSystem.ViewModels.Students;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ExaminationSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public bool Post(StudentCreateViewModel studentCreateViewModel)
        {
            var student = studentCreateViewModel.MapOne<StudentCreateDTO>();

            _studentService.AddStudent(student);

            return true;
        }
    }
}
