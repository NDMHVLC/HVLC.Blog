
using HVLC.Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HVLC.Blog.Entity.Entities
{
    public class Category : EntityBase , IEntity
    {
        public Category()
        {
        }

        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; set; }


        public ICollection<Article> Articles { get; set; }
    }
}
