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
    public class ImageConfiguration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                Id = Guid.Parse("F937CD07-2E0F-4792-A3AA-5493FE6D3597"),
                FileName = "images/C#/testimage",
                FileType = "jpg",
                CreatedBy = "Admin Test C#",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            },
            new Image
            {
                Id = Guid.Parse("2F8BFBE5-5A3B-4124-9617-EDBA59927D75"),
                FileName = "images/Sql/testimage",
                FileType = "jpg",
                CreatedBy = "Admin Test Sql",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
            });
        }
    }
}
