using System.ComponentModel.DataAnnotations;

namespace FSDProject1.Domain
{
    public class Subjects
    {
        [Key]     
        public int SubjectId { get; set; }

        public string Name { get; set; }

        public DateTime DateCreated { get; set; }

        public DateTime DateUpdated { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedBy { get; set; }

        //Foreign Key to Tutor
        public int TutorId { get; set; }

        public Tutors Tutor { get; set; }// Navigation Property


    }
}
