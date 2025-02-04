using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FSDProject1.Data;
using FSDProject1.Configurations.Entities;
using FSDProject1.Domain;

namespace FSDProject1.Data
{
    public class FSDProject1Context(DbContextOptions<FSDProject1Context> options) : IdentityDbContext<FSDProject1User>(options)
    {
        public DbSet<FSDProject1.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<FSDProject1.Domain.Reviews> Reviews { get; set; } = default!;
        public DbSet<FSDProject1.Domain.StudentUser> StudentUser { get; set; } = default!;
        public DbSet<FSDProject1.Domain.Subjects> Subjects { get; set; } = default!;
        public DbSet<FSDProject1.Domain.Tutors> Tutors { get; set; } = default!;
        public DbSet<FSDProject1.Domain.AdminTutor> AdminTutor { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ✅ Apply Seed Data
            modelBuilder.ApplyConfiguration(new AdminTutorSeed());
            modelBuilder.ApplyConfiguration(new StudentUserSeed());
            modelBuilder.ApplyConfiguration(new SubjectSeed());
            modelBuilder.ApplyConfiguration(new TutorSeed());
            modelBuilder.ApplyConfiguration(new BookingSeed());
            modelBuilder.ApplyConfiguration(new ReviewsSeed());

            // ✅ One-to-Many Relationship (Each subject has ONE "primary" tutor)
            modelBuilder.Entity<Subjects>()
                .HasOne(s => s.Tutor)
                .WithMany() // No back-reference needed
                .HasForeignKey(s => s.TutorId)
                .OnDelete(DeleteBehavior.Restrict); // Prevent accidental deletion

            // ✅ Many-to-Many Relationship (Subjects <-> Tutors)
            modelBuilder.Entity<Tutors>()
                .HasMany(t => t.Subjects)
                .WithMany(s => s.Tutors)
                .UsingEntity<Dictionary<string, object>>(
                    "TutorSubject",
                    t => t.HasOne<Subjects>().WithMany().HasForeignKey("SubjectId"),
                    s => s.HasOne<Tutors>().WithMany().HasForeignKey("TutorId"));
        }
    }
}
