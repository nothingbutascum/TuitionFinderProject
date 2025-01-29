using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using FSDProject1.Data;
using FSDProject1.Configurations.Entities;

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
            modelBuilder.ApplyConfiguration(new AdminTutorSeed());
            modelBuilder.ApplyConfiguration(new StudentUserSeed());
            modelBuilder.ApplyConfiguration(new SubjectSeed());
            modelBuilder.ApplyConfiguration(new TutorSeed());
            modelBuilder.ApplyConfiguration(new BookingSeed());
            modelBuilder.ApplyConfiguration(new ReviewsSeed());
        }
    }
}
