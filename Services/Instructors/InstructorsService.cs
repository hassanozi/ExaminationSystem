using ExaminationSystem.DTOs.Instructor;
using ExaminationSystem.Helpers;
using ExaminationSystem.Models;
using ExaminationSystem.Repositories;
using ExaminationSystem.ViewModels.Instructors;

namespace ExaminationSystem.Services.Instructors
{
    public class InstructorsService : IInstructorsService
    {
        IRepository<Instructor> _repository;

        public InstructorsService(IRepository<Instructor> repository)
        {
            _repository = repository;
        }

        public void AddInstructor(InstructorCreateDTO  instructorCreateDTO)
        {
            var instructor = instructorCreateDTO.MapOne<Instructor>();
          
            _repository.Add(instructor);

            _repository.SaveChanges();
        }

        public void DeleteInstructor(int id)
        {
            _repository.Delete(id);
        }

        public IEnumerable<InstructorCreateDTO> GetAllInstructors()
        {
            var instructors = _repository.GetAll();

            return instructors.Map<InstructorCreateDTO>();
        }

        public Instructor GetInstructorById(int id)
        {
           return _repository.GetWithTrackinByID(id);
        }

        public void UpdateInstructor(InstructorUpdateViewModel instructorUpdateViewModel)
        {
            var instructor = _repository.GetWithTrackinByID(instructorUpdateViewModel.ID);

            instructor.MapOne<InstructorUpdateViewModel>();

            //instructor.FirstName = instructorUpdateViewModel.FirstName;
            //instructor.LastName = instructorUpdateViewModel.LastName;
            //instructor.BirthDate = instructorUpdateViewModel.BirthDate;
            //instructor.EnrolmentDate = instructorUpdateViewModel.EnrolmentDate;
           

            _repository.Update(instructor);
            _repository.SaveChanges();
        }
    }
}
