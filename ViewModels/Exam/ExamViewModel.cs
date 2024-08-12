using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Exam
{
    public class ExamViewModel
    {
        public DateTime StartDate { get; set; }
        public int NumberOfQuestions { get; set; }
        public int TotalGrade { get; set; }
        public ExamType eType { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public string FirstQuestion { get; set; }

        public ICollection<int> QuestionsIDs { get; set; }
    }
}
