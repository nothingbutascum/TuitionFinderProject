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
                    Time = "10:00", // Changed to string format for consistency
                    Status = "Confirmed",
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "SystemAdmin",
                    UpdatedBy = "SystemAdmin",
                    StudentUserId = 1,
                    TutorId = 1
                },
                new Booking
                {
                    BookingID = 2,
                    Date = new DateTime(2025, 1, 11),
                    Time = "14:00", // Changed to string format
                    Status = "Pending",
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "AdminUser",
                    UpdatedBy = "AdminUser",
                    StudentUserId = 2,
                    TutorId = 2
                },
                new Booking
                {
                    BookingID = 3,
                    Date = new DateTime(2025, 1, 12),
                    Time = "16:00", // Changed to string format
                    Status = "Cancelled",
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "AdminAssistant",
                    UpdatedBy = "AdminAssistant",
                    StudentUserId = 3,
                    TutorId = 3
                }
            );
        }
    }
}