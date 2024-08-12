using System.ComponentModel.DataAnnotations.Schema;

namespace ExaminationSystem.Models
{
    public class Instructor : BaseModel
    {
        public Instructor()
        {
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EnrolmentDate { get; set; }

        public HashSet<Exam> Exams { get; set; }
        public HashSet<InstructorCourse> instructorCourses { get; set; }
        public HashSet<Question>  Questions { get; set; }

    }

    
}
