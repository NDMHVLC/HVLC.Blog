using FluentValidation;
using HVLC.Blog.Entity.Entities;

namespace HVLC.Blog.Service.FluentValidations
{
    public class ArticleValidator : AbstractValidator<Article>
    {
        public ArticleValidator()
        {
            RuleFor(x => x.Title).NotEmpty().NotNull().MinimumLength(3).MaximumLength(150).WithName("Başlık");
            RuleFor(x => x.Content).NotEmpty().NotNull().MinimumLength(15).MaximumLength(450).WithName("İçerik");
        }
    }
}
