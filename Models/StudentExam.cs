﻿namespace ExaminationSystem.Models
{
    public class StudentExam : BaseModel
    {
        public int Result { get; set; }
        public int ExamId { get; set; }
        public Exam Exam { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public bool isTaken { get; set; }
    }
}
