using FSDProject1.Domain;
using System.ComponentModel.DataAnnotations;

namespace FSDProject1.Domain
{
    public class Tutors
    {
        [Key]
        public int TutorId { get; set; } // Primary Key


        public string? Name { get; set; } = string.Empty;


        public string? Qualification { get; set; } = string.Empty;

        public string? Experience { get; set; } = string.Empty;

        public decimal? HourlyRate { get; set; }

        public decimal? Rating { get; set; }


        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }


        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        //Navigation Property
        public ICollection<Subjects> Subjects { get; set; }

        //Foreign Key

        public int? StudentUserId    { get; set; }

        public StudentUser? StudentUser { get; set; }



    }

}

