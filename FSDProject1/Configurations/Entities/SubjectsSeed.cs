using FSDProject1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject1.Configurations.Entities
{
    public class SubjectSeed : IEntityTypeConfiguration<Subjects>
    {
        public void Configure(EntityTypeBuilder<Subjects> builder)
        {
            builder.HasData(
                new Subjects
                {
                    SubjectId = 1,
                    Name = "Mathematics",
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "SystemAdmin",
                    UpdatedBy = "SystemAdmin",
                    TutorId = 1 // Ensure this ID matches an existing Tutor
                },
                new Subjects
                {
                    SubjectId = 2,
                    Name = "Physics",
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc), // Static value
                    CreatedBy = "AdminUser",
                    UpdatedBy = "AdminUser",
                    TutorId = 1
                },
                new Subjects
                {
                    SubjectId = 3,
                    Name = "Chemistry",
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "AdminAssistant",
                    UpdatedBy = "AdminAssistant",
                    TutorId = 3
                }
            );
        }
    }
}
