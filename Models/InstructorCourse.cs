namespace ExaminationSystem.Models
{
    public class InstructorCourse : BaseModel
    {
        public Instructor Instructor { get; set; }
        public int InsructorId { get; set; }
        public Course Course { get; set; }
        public int CourseId { get; set; }
    }
}
