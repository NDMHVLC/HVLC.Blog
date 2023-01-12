using HVLC.Blog.Data.Context;
using HVLC.Blog.Data.Repositories.Abstract;
using HVLC.Blog.Data.Repositories.Concrete;
using HVLC.Blog.Data.UnitOfWorks.Abstract;
using HVLC.Blog.Data.UnitOfWorks.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HVLC.Blog.Data.Extensions
{
    public static class DataLayerExtensions
    {
        public static IServiceCollection LoadDataLayerExtension(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddDbContext<BlogAppDbContext>(opt => opt.UseSqlServer(config.GetConnectionString("DefaultConnection")));
            return services;
        }
    }
}
