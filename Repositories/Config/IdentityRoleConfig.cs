using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repositories.Config;

public class IdentityRoleConfig : IEntityTypeConfiguration<IdentityRole>
{
    public void Configure(EntityTypeBuilder<IdentityRole> builder)
    {
        builder.HasData(
            new IdentityRole(){ Id = "7a5058c1-be92-4a0a-bb0f-c91f980d1f81", Name = "User", NormalizedName = "USER" },
            new IdentityRole(){ Id = "de615f29-51de-4138-9413-d15ea01a596a", Name = "Editor", NormalizedName = "EDITOR" },
            new IdentityRole(){ Id = "0abcba21-dec9-4500-b23a-bb13195a9701", Name = "Admin", NormalizedName = "ADMIN" }
        );
    }
}