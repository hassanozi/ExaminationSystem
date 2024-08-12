namespace ExaminationSystem.Models
{
    public class Exam : BaseModel
    {
        public Exam()
        {
        }

        public DateTime StartDate { get; set; }
        public int TotalGrade { get; set; }
        public Instructor Instructor { get; set; }
        public int InstructorId { get; set; }
        public Course Course { get; set; }
        public int? CourseId { get; set; }
        public ExamType eType { get; set; }
        public Level Level { get; set; }

        public ICollection<ExamQuestion> ExamQuestions { get; set; }
        public ICollection<StudentExam>  studentExams { get; set; }


    }

    public enum ExamType
    {
        Quize = 1,
        Final = 2
    }

    public enum Level
    {
        simple = 1,
        mediume = 2,
        hard = 3
    }
}
