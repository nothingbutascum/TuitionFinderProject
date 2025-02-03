using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FSDProject1.Domain
{
    public class Booking
    {
        [Key]
        public int BookingID { get; set; } // Primary Key
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Status { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
        public string CreatedBy { get; set; }
        public string UpdatedBy { get; set; }


        public int StudentUserId { get; set; } // Foreign Key referencing StudentUser
        public StudentUser? StudentUser { get; set; } //Navigation Propterty
       

        public int TutorID { get; set; } // Foreign Key referencing Tutor
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Tutors? Tutor { get; set; }
    }
}
