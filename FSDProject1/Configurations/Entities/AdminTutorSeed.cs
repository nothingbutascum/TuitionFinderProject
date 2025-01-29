using FSDProject1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject1.Configurations.Entities
{
    public class AdminTutorSeed : IEntityTypeConfiguration<AdminTutor>
    {
        public void Configure(EntityTypeBuilder<AdminTutor> builder)
        {
            builder.HasData(
                new AdminTutor
                {
                    AdminTutorId = 1,
                    DateCreated = new DateOnly(2025, 1, 1),
                    DateUpdated = new DateTime(2025, 1, 1, 12, 0, 0), // Static value
                    CreatedBy = "SystemAdmin",
                    UpdatedBy = "SystemAdmin",
                    TutorId = 1, // Ensure this ID matches an existing Tutor
                    SubjectId = 1  // Ensure this ID matches an existing Subject
                },
                new AdminTutor
                {
                    AdminTutorId = 2,
                    DateCreated = new DateOnly(2025, 1, 2),
                    DateUpdated = new DateTime(2025, 1, 2, 12, 0, 0), // Static value
                    CreatedBy = "AdminUser",
                    UpdatedBy = "AdminUser",
                    TutorId = 2,
                    SubjectId = 2
                },
                new AdminTutor
                {
                    AdminTutorId = 3,
                    DateCreated = new DateOnly(2025, 1, 3),
                    DateUpdated = new DateTime(2025, 1, 3, 12, 0, 0), // Static value
                    CreatedBy = "AdminAssistant",
                    UpdatedBy = "AdminAssistant",
                    TutorId = 3,
                    SubjectId = 3
                }
            );
        }
    }
}
