using BlazorBlog.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBlog.Shared.Services.Interfaces
{
    public interface IPostService
    {
        Task<Post> GetPostById(int id);
        Task<List<Post>> GetAllPosts();
        Task<List<Post>> GetPostsByUserId(int id);
        Task<List<Post>> GetPostsByBlogId(int id);

        Task<Blog> AddPost(Post post);
        Task<Blog> EditPost(int id, Post post);
        Task<bool> DeletePost(int id);
    }
}
