using ExaminationSystem.DTOs.Student;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;
using ExaminationSystem.ViewModels.Students;

namespace ExaminationSystem.Services.Students
{
    public class StudentService : IStudentService
    {
        IRepository<Student> _studentRepository;

        public StudentService(IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public void AddStudent(StudentCreateDTO studentCreateViewModel)
        {
            var student = studentCreateViewModel.MapOne<Student>();

            _studentRepository.Add(student);

            _studentRepository.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void update(StudentUpdateViewModel studentUpdateViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
