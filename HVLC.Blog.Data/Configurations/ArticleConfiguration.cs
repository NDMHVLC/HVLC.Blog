using HVLC.Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HVLC.Blog.Data.Configurations
{
    public class ArticleConfiguration : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.Parse("84093148-E77C-41A7-9FB9-67011DC554E8"),
                Title= "C# deneme makalesi",
                Content= "C#; Microsoft tarafından .NET Teknolojisi için geliştirilen modern bir programlama dilidir. Sözdizimi C-like bir deneyim sunar. Microsoft tarafından geliştirilmiş olsa da ECMA ve ISO standartları altına alınmıştır. C programlama dilinde bir tam sayı değişkeni 1 artırmak için değişkenden sonra \"++\" eki kullanılır.",
                ViewCount= 1,
                CreatedBy = "Admin Test C#",
                CreatedDate= DateTime.Now, 
                CategoryId = Guid.Parse("74FDC9DB-59B2-4AF3-A039-407FE415676B"),
                ImageId = Guid.Parse("F937CD07-2E0F-4792-A3AA-5493FE6D3597"),
                UserId = Guid.Parse("B25A724B-E00B-4F00-8CAC-5E3C6F5C9909"),
                IsDeleted=false
            },
            new Article
            {
                Id = Guid.Parse("6939BDE3-8630-4BFD-A506-E1AC2DF40497"),
                Title = "Sql deneme makalesi",
                Content = "SQL, verileri yönetmek ve tasarlamak için kullanılan bir dildir. SQL, kendisi bir programlama dili olmamasına rağmen birçok kişi tarafından programlama dili olarak bilinir. SQL herhangi bir veri tabanı ortamında kullanılan bir alt dildir.",
                ViewCount = 1,
                CreatedBy = "Admin Test Sql",
                CreatedDate = DateTime.Now,
                CategoryId = Guid.Parse("B6C4714C-D3AF-4E01-A3DA-322DC9F1E167"),
                ImageId = Guid.Parse("2F8BFBE5-5A3B-4124-9617-EDBA59927D75"),
                UserId = Guid.Parse("7E5DB1E2-AC0B-4F86-BA50-080F744C2BDB"),
                IsDeleted = false
            });
        }
    }
}
