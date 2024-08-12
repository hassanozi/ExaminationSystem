namespace ExaminationSystem.DTOs.Choice
{
    public class ChoiceCreateDTO
    {
        public string Text { get; set; }
        public bool IsRightAnswer { get; set; }
        public int QuestionId { get; set; }
    }
}
