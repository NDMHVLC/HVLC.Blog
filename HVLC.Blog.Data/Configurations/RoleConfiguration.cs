﻿using HVLC.Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HVLC.Blog.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<AppRole>
    {
        public void Configure(EntityTypeBuilder<AppRole> builder)
        {
            // Primary key
            builder.HasKey(r => r.Id);

            // Index for "normalized" role name to allow efficient lookups
            builder.HasIndex(r => r.NormalizedName).HasName("RoleNameIndex").IsUnique();

            // Maps to the AspNetRoles table
            builder.ToTable("AspNetRoles");

            // A concurrency token for use with the optimistic concurrency checking
            builder.Property(r => r.ConcurrencyStamp).IsConcurrencyToken();

            // Limit the size of columns to use efficient database types
            builder.Property(u => u.Name).HasMaxLength(256);
            builder.Property(u => u.NormalizedName).HasMaxLength(256);

            // The relationships between Role and other entity types
            // Note that these relationships are configured with no navigation properties

            // Each Role can have many entries in the UserRole join table
            builder.HasMany<AppUserRole>().WithOne().HasForeignKey(ur => ur.RoleId).IsRequired();

            // Each Role can have many associated RoleClaims
            builder.HasMany<AppRoleClaim>().WithOne().HasForeignKey(rc => rc.RoleId).IsRequired();

            builder.HasData(new AppRole
            {
                Id = Guid.Parse("66D926ED-02FB-47D8-8D89-AC4B74E61E0A"),
                Name = "Superadmin",
                NormalizedName = " SUPERADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            }, new AppRole
            {
                Id = Guid.Parse("9E503C0F-1158-4BD3-8DC6-807EAD3B5D5C"),
                Name = "Admin",
                NormalizedName = " ADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            }, new AppRole
            {
                Id = Guid.Parse("2611333B-A652-40C5-A20F-99FD9514E50C"),
                Name = "User",
                NormalizedName = " USER",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });
        }
    }
}
