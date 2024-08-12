namespace ExaminationSystem.ViewModels.Instructors
{
    public class InstructorViewModel
    {
        public string FName { get; set; }
        public string LName { get; set; }

        public string FullName => $"{FName} {LName}";
    }
}
