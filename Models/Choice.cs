namespace ExaminationSystem.Models
{
    public class Choice : BaseModel
    {
        public string Text { get; set; }
        public bool IsRightAnswer { get; set; }
        public int QuestionsId { get; set; }
        public Question Question { get; set; }
    }
}
