using BlazorBlog.Shared.Services.Interfaces;
using Microsoft.AspNetCore.Http;

namespace BlazorBlog.Shared.Services.Server
{
    public class BasicImageService : IImageService
    {
        public string ContentType(IFormFile image)
        {
            return Path.GetExtension(image?.FileName);
        }

        public string DecodeImage(byte[] data, string type)
        {
            if (data is null || type is null) return null;
            return $"data:{type};base64,{Convert.ToBase64String(data)}";
        }

        public async Task<byte[]> EncodeImageAsync(IFormFile image)
        {
            if (image is null) return null;

            using var ms = new MemoryStream();

            await image.CopyToAsync(ms);
            return ms.ToArray();
        }

        public async Task<byte[]> EncodeImageAsync(string fileName)
        {
            var imagePath = $"{Directory.GetCurrentDirectory()}/wwwroot/img/{fileName}";
            return await File.ReadAllBytesAsync(imagePath);
        }

        public bool isValidType(IFormFile image)
        {
            //var type = Path.GetExtension(image?.FileName);
            var type = ContentType(image);
            type = type.Split(".")[1];

            var typeList = new List<string>();

            typeList.Add("png");
            typeList.Add("jpg");
            typeList.Add("jpeg");
            typeList.Add("bmp");
            typeList.Add("tiff");
            typeList.Add("gif");

            var isValid = typeList.Contains(type);

            return isValid;
        }

        public int Size(IFormFile image)
        {
            return Convert.ToInt32(image?.Length);
        }

        public bool IsValidSize(IFormFile image)
        {
            var maxFileSize = 2 * 1024 * 1024;
            return Size(image) < maxFileSize ? true : false;
        }
    }
}