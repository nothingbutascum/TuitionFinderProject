using FSDProject1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject1.Configurations.Entities
{
    public class StudentUserSeed : IEntityTypeConfiguration<StudentUser>
    {
        public void Configure(EntityTypeBuilder<StudentUser> builder)
        {
            builder.HasData(
                new StudentUser
                {
                    StudentUserId = 1,
                    Name = "John Doe",
                    Email = "johndoe@example.com",
                    Age = 21,
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "SystemAdmin",
                    UpdatedBy = "SystemAdmin"
                },
                new StudentUser
                {
                    StudentUserId = 2,
                    Name = "Jane Smith",
                    Email = "janesmith@example.com",
                    Age = 22,
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "AdminUser",
                    UpdatedBy = "AdminUser"
                },
                new StudentUser
                {
                    StudentUserId = 3,
                    Name = "Alice Johnson",
                    Email = "alicejohnson@example.com",
                    Age = 20,
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "AdminAssistant",
                    UpdatedBy = "AdminAssistant"
                }
            );
        }
    }
}
