using ExaminationSystem.DTOs.ExamQuestion;
using ExaminationSystem.Models;

namespace ExaminationSystem.DTOs.Exam
{
    public class ExamCreateDTO
    {
        public DateTime StartDate { get; set; }
        public int TotalGrade { get; set; }
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public ExamType eType { get; set; }
        public IEnumerable<int> QuestionsIDs { get; set; }
        public HashSet<ExamQuestionCreateDTO> examQuestionCreateDTOs { get; set; }
        public IEnumerable<int> CourseIDs { get; set; }

    }
}
