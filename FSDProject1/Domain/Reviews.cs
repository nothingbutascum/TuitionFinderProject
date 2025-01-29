using System.ComponentModel.DataAnnotations;

namespace FSDProject1.Domain
{
    public class Reviews
    {

    [Key]
    public string ReviewsId { get; set; }
    public string? Rating { get; set; }

    public string? Comments { get; set; }

    public DateTime DateCreated { get; set; }

    public DateTime DateUpdated { get; set; }

    public string CreatedBy     { get; set; }

    public string UpdatedBy { get; set; }

        public int BookingId { get; set; } // ForeignKey

        public Booking Booking  { get; set; } // Navigation property

    }
}
