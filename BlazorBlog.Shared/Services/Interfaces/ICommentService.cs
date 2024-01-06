using BlazorBlog.Shared.Models;

namespace BlazorBlog.Shared.Services.Interfaces
{
    public interface ICommentService
    {
        Task<Comment> GetCommentById(int id);

        Task<List<Comment>> GetAllComments();

        Task<List<Comment>> GetCommentsByUserId(int id);

        Task<Comment> AddComment(Comment comment);

        Task<Comment> EditComment(int id, Comment comment);

        Task<bool> DeleteComment(int id);
    }
}