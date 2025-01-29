using FSDProject1.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FSDProject1.Configurations.Entities
{
    public class ReviewsSeed : IEntityTypeConfiguration<Reviews>
    {
        public void Configure(EntityTypeBuilder<Reviews> builder)
        {
            builder.HasData(
                new Reviews
                {
                    ReviewsId = "R001",
                    Rating = "5",
                    Comments = "Excellent session! Very helpful and informative.",
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "Student1",
                    UpdatedBy = "Student1",
                    BookingId = 1 // Ensure this ID matches an existing Booking
                },
                new Reviews
                {
                    ReviewsId = "R002",
                    Rating = "4",
                    Comments = "Good session, but a bit rushed.",
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "Student2",
                    UpdatedBy = "Student2",
                    BookingId = 2
                },
                new Reviews
                {
                    ReviewsId = "R003",
                    Rating = "3",
                    Comments = "Session was okay, could be improved.",
                    DateCreated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    DateUpdated = new DateTime(2024, 1, 26, 12, 0, 0, DateTimeKind.Utc),
                    CreatedBy = "Student3",
                    UpdatedBy = "Student3",
                    BookingId = 3
                }
            );
        }
    }
}
