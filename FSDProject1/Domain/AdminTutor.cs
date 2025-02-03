using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FSDProject1.Domain
{
    public class AdminTutor
    {
        [Key]
        public int AdminTutorId { get; set; }

        public DateOnly? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string? CreatedBy { get; set; }
        public string? UpdatedBy { get; set; }

        public int TutorId { get; set; }
        public Tutors? Tutor { get; set; }
        
        public int SubjectId { get; set; }
        [DeleteBehavior(DeleteBehavior.Restrict)]
        public Subjects? Subject { get; set; }


    }
}
