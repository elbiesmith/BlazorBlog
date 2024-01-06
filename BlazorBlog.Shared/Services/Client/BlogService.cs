using BlazorBlog.Shared.Models;
using BlazorBlog.Shared.Services.Interfaces;

namespace BlazorBlog.Shared.Services.Client
{
    public class BlogService : IBlogService
    {
        public Task<Blog> AddBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteBlog(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Blog> EditBlog(int id, Blog blog)
        {
            throw new NotImplementedException();
        }

        public Task<List<Blog>> GetAllBlogs()
        {
            throw new NotImplementedException();
        }

        public Task<Blog> GetBlogById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Blog>> GetBlogsByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}