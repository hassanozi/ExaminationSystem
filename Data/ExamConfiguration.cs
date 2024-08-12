using ExaminationSystem.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExaminationSystem.Data
{
    public class ExamConfiguration : IEntityTypeConfiguration<Exam>
    {
        public void Configure(EntityTypeBuilder<Exam> builder)
        {
            //builder.HasOne(i => i.Instructor)
            //    .WithMany()
            //    .HasForeignKey(i => i.InstructorId)
            //    .OnDelete(DeleteBehavior.SetNull);

            builder.HasOne(c => c.Course)
                .WithMany()
                .HasForeignKey(c => c .CourseId)
                .OnDelete(DeleteBehavior.SetNull);
        }
    }
}
