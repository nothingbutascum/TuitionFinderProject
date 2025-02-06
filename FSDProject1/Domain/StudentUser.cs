using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity; // Make sure you have this import

namespace FSDProject1.Domain
{
    public class StudentUser
    {
        [Key]
        public int StudentUserId { get; set; } // Primary Key


        public string? Name { get; set; }
        public string? Email { get; set; }
        public int? Age { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

       
        // Navigation Property for Bookings (if needed)
        public virtual ICollection<Booking>? Bookings { get; set; }
    }
}
