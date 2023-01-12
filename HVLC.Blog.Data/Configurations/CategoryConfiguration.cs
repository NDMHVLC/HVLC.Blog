using HVLC.Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HVLC.Blog.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("74FDC9DB-59B2-4AF3-A039-407FE415676B"),
                Name = "C#",
                CreatedBy = "Admin Test C#",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                Id = Guid.Parse("B6C4714C-D3AF-4E01-A3DA-322DC9F1E167"),
                Name="Sql",
                CreatedDate= DateTime.Now,
                CreatedBy="Admin Test Sql",
                IsDeleted= false
            });
        }
    }
}
