using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace FSDProject1.Configurations.Entities
{
    public class RoleSeed : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
             new IdentityRole
             {
                 Id = "ad2bcf0c-20db-474f-8407-5a6b159518ba",
                 Name = "Administrator",
                 NormalizedName = "ADMINISTRATOR"
             },
             new IdentityRole
             {
                 Id = "bd2bcf0c-20db-474f-8407-5a6b159518bb",
                 Name = "User",
                 NormalizedName = "USER"
             }
             );
        }
    }
}
