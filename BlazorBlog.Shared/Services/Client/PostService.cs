using BlazorBlog.Shared.Models;
using BlazorBlog.Shared.Services.Interfaces;

namespace BlazorBlog.Shared.Services.Client
{
    public class PostService : IPostService
    {
        public Task<Post> AddPost(Post post)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Post> EditPost(int id, Post post)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetAllPosts()
        {
            throw new NotImplementedException();
        }

        public Task<Post> GetPostById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetPostsByBlogId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetPostsByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}