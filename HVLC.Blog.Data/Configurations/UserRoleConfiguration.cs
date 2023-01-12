using HVLC.Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HVLC.Blog.Data.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            // Primary key
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("B25A724B-E00B-4F00-8CAC-5E3C6F5C9909"),
                RoleId = Guid.Parse("66D926ED-02FB-47D8-8D89-AC4B74E61E0A")
            }, new AppUserRole
            {
                UserId = Guid.Parse("7E5DB1E2-AC0B-4F86-BA50-080F744C2BDB"),
                RoleId = Guid.Parse("9E503C0F-1158-4BD3-8DC6-807EAD3B5D5C")
            });
        }
    }
}
