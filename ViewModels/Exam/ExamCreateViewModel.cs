using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Exam
{
    public class ExamCreateViewModel
    {
        public DateTime StartDate { get; set; }
        public int TotalGrade { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public ExamType eType { get; set; }
        public IEnumerable<int> QuestionsIDs { get; set; }
        public IEnumerable<int> StudentIDs { get; set; }
        public IEnumerable<int> CourseIDs { get; set; }


    }
}
