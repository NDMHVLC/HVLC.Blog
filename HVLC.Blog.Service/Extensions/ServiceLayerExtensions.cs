using HVLC.Blog.Service.Services.Abstract;
using HVLC.Blog.Service.Services.Concrete;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace HVLC.Blog.Service.Extensions
{
    public static class ServiceLayerExtensions
    {
        public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
        {
            var assembly = Assembly.GetExecutingAssembly();

            services.AddScoped<IArticleService, ArticleManager>();

            services.AddAutoMapper(assembly);

            return services;
        }
    }
}
