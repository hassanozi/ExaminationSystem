﻿using ExaminationSystem.DTOs.Exam;

namespace ExaminationSystem.Mediators.Exam
{
    public interface IExamMediator
    {
        void Add(ExamCreateDTO examCreateDTO);
    }
}
