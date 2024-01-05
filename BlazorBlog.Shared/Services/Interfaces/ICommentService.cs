using BlazorBlog.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorBlog.Shared.Services.Interfaces
{
    public interface ICommentService
    {
        Task<Blog> GetCommentById(int id);
        Task<List<Blog>> GetAllComments();
        Task<List<Blog>> GetCommentsByUserId(int id);

        Task<Blog> AddComment(Comment comment);
        Task<Blog> EditComment(int id, Comment comment);
        Task<bool> DeleteComment(int id);
    }
}
