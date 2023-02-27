using HVLC.Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HVLC.Blog.Entity.Entities
{
    public class Article : EntityBase , IEntity
    {
        public Article()
        {
        }

        public Article(string title, string content, Guid userId, string createdBy, Guid categoryId, Guid ımageId)
        {
            Title = title;
            Content = content;
            CategoryId = categoryId;
            ImageId = ımageId;
            UserId = userId;
            CreatedBy = createdBy;
        }

        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; } = 0;

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }


        public Guid? ImageId { get; set; }
        public Image Image { get; set; }

        public Guid UserId { get; set; }
        public AppUser User { get; set; }

    }
}
