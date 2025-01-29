using System.ComponentModel.DataAnnotations;

namespace FSDProject1.Domain
{
    public class StudentUser
    {
        [Key]
        public int StudentUserId { get; set; } // Primary Key
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
       
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }

        // Navigation Properties
        public virtual ICollection<Booking> Bookings { get; set; }
    }
}
