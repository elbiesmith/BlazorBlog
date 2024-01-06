using BlazorBlog.Shared.Models;
using BlazorBlog.Shared.Services.Interfaces;

namespace BlazorBlog.Shared.Services.Server
{
    public class CommentService : ICommentService
    {
        public Task<Comment> AddComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteComment(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Comment> EditComment(int id, Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetAllComments()
        {
            throw new NotImplementedException();
        }

        public Task<Comment> GetCommentById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Comment>> GetCommentsByUserId(int id)
        {
            throw new NotImplementedException();
        }
    }
}