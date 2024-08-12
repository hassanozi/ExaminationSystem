namespace ExaminationSystem.DTOs.Instructor
{
    public class InstructorCreateDTO
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime EnrolmentDate { get; set; }
    }
}
