using AutoMapper;
using HVLC.Blog.Data.UnitOfWorks.Abstract;
using HVLC.Blog.Entity.DTOs.Articles;
using HVLC.Blog.Entity.Entities;
using HVLC.Blog.Service.Services.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HVLC.Blog.Service.Services.Concrete
{
    public class ArticleManager : IArticleService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ArticleManager(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<List<ArticleDto>> GetAllArticleAsync()
        {
            var articles = await _unitOfWork.GetRepository<Article>().GetAllAsync();
            var map = _mapper.Map<List<ArticleDto>>(articles);

            return map;
        }
    }
}
