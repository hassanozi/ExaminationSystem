using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Instructors
{
    public class InstructorCreateViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EnrolmentDate { get; set; }

    }
}
