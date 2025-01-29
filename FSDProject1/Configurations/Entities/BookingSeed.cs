using FSDProject1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject1.Configurations.Entities
{
    public class BookingSeed : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasData(
                new Booking
                {
                    BookingID = 1,
                    Date = new DateTime(2025, 1, 10),
                    Time = new DateTime(2025, 1, 10, 10, 0, 0),
                    Status = "Confirmed",
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "SystemAdmin",
                    UpdatedBy = "SystemAdmin",
                    StudentUserId = 1, // Ensure this ID matches an existing StudentUser
                    TutorID = 1 // Ensure this ID matches an existing Tutor
                },
                new Booking
                {
                    BookingID = 2,
                    Date = new DateTime(2025, 1, 11),
                    Time = new DateTime(2025, 1, 11, 14, 0, 0),
                    Status = "Pending",
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "AdminUser",
                    UpdatedBy = "AdminUser",
                    StudentUserId = 2,
                    TutorID = 2
                },
                new Booking
                {
                    BookingID = 3,
                    Date = new DateTime(2025, 1, 12),
                    Time = new DateTime(2025, 1, 12, 16, 0, 0),
                    Status = "Cancelled",
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "AdminAssistant",
                    UpdatedBy = "AdminAssistant",
                    StudentUserId = 3,
                    TutorID = 3
                }
            );
        }
    }
}
