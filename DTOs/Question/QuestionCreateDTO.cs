using ExaminationSystem.DTOs.Choice;

namespace ExaminationSystem.DTOs.Question
{
    public class QuestionCreateDTO
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int Grade { get; set; }
        public int InstructorId { get; set; }
        public IEnumerable<ChoiceCreateDTO> ChoicesDetails { get; set; }
    }
}
