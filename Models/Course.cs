namespace ExaminationSystem.Models
{
    public class Course : BaseModel
    {
        public string Name { get; set; }
        public int CreditHours { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public HashSet<InstructorCourse> instructorCourses { get; set; }
    }
}
