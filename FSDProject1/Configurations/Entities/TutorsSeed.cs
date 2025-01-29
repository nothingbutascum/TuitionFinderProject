using FSDProject1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject1.Configurations.Entities
{
    public class TutorSeed : IEntityTypeConfiguration<Tutors>
    {
        public void Configure(EntityTypeBuilder<Tutors> builder)
        {
            builder.HasData(
                new Tutors
                {
                    TutorId = 1,
                    Name = "Dr. John Smith",
                    Qualification = "PhD in Mathematics",
                    Experience = "10 years of teaching experience",
                    HourlyRate = 50.00m,
                    Rating = 4.8m,
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "SystemAdmin",
                    UpdatedBy = "SystemAdmin",
                    StudentUserId = 1 // Ensure this ID matches an existing StudentUser
                },
                new Tutors
                {
                    TutorId = 2,
                    Name = "Ms. Jane Doe",
                    Qualification = "Master's in Physics",
                    Experience = "8 years of tutoring experience",
                    HourlyRate = 45.00m,
                    Rating = 4.6m,
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "AdminUser",
                    UpdatedBy = "AdminUser",
                    StudentUserId = 2
                },
                new Tutors
                {
                    TutorId = 3,
                    Name = "Prof. Alice Brown",
                    Qualification = "PhD in Chemistry",
                    Experience = "15 years of academic experience",
                    HourlyRate = 60.00m,
                    Rating = 4.9m,
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "AdminAssistant",
                    UpdatedBy = "AdminAssistant",
                    StudentUserId = 3
                }
            );
        }
    }
}
