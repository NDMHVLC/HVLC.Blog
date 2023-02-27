using AutoMapper;
using HVLC.Blog.Entity.DTOs.Articles;
using HVLC.Blog.Entity.Entities;

namespace HVLC.Blog.Service.AutoMapper.Articles
{
    public class ArticleProfile : Profile
    {
        public ArticleProfile()
        {
            CreateMap<ArticleDto,Article>().ReverseMap();
            CreateMap<ArticleUpdateDto,Article>().ReverseMap();
            CreateMap<ArticleUpdateDto,ArticleDto>().ReverseMap();
            CreateMap<ArticleAddDto,Article>().ReverseMap();
        }
    }
}
