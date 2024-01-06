using BlazorBlog.Shared.Models;

namespace BlazorBlog.Shared.Services.Interfaces
{
    public interface IPostService
    {
        Task<Post> GetPostById(int id);

        Task<List<Post>> GetAllPosts();

        Task<List<Post>> GetPostsByUserId(int id);

        Task<List<Post>> GetPostsByBlogId(int id);

        Task<Post> AddPost(Post post);

        Task<Post> EditPost(int id, Post post);

        Task<bool> DeletePost(int id);
    }
}