using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBlog.Shared.Services.Interfaces
{
    public interface IImageService
    {
        Task<byte[]> EncodeImageAsync(IFormFile image);

        Task<byte[]> EncodeImageAsync(string image);

        string DecodeImage(byte[] data, string type);

        string ContentType(IFormFile image);

        int Size(IFormFile image);

        bool isValidType(IFormFile image);

        bool IsValidSize(IFormFile image);
    }
}
