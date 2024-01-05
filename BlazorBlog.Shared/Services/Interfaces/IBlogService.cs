using BlazorBlog.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBlog.Shared.Services.Interfaces
{
    public interface IBlogService
    {
        Task<Blog> GetBlogById(int id);
        Task<List<Blog>> GetAllBlogs();
        Task<List<Blog>> GetBlogsByUserId(int id);

        Task<Blog> AddBlog(Blog blog);
        Task<Blog> EditBlog(int id, Blog blog);
        Task<bool> DeleteBlog(int id);


    }
}
