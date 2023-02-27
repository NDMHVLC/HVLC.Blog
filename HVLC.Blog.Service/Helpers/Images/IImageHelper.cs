using HVLC.Blog.Entity.DTOs.Images;
using HVLC.Blog.Entity.Enums;
using Microsoft.AspNetCore.Http;

namespace HVLC.Blog.Service.Helpers.Images
{
    public interface IImageHelper
    {
        Task<ImageUploadedDto> Upload(string name, IFormFile imageFile, ImageType imageType,string folderName = null);
        void Delete(string imageName);
    }
}
