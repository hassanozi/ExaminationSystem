using ExaminationSystem.DTOs.Choice;
using ExaminationSystem.Models;

namespace ExaminationSystem.ViewModels.Exam
{
    public class QuestionCreateViewModel
    {
        public string Text { get; set; }
        public int Grade { get; set; }
        public int InstructorId { get; set; }
        public IEnumerable<ChoiceCreateDTO> Choices { get; set; }

    }
}
