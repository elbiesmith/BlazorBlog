using BlazorBlog.Shared.Models;

namespace BlazorBlog.Shared.Services.Interfaces
{
    public interface ITagService
    {
        Task<List<Tag>> GetAllTags();

        Task<List<Post>> GetPostsByTagId(int id);

        Task<List<Tag>> GetTagsByPostId(int id);

        Task<Tag> AddTag(Tag tag);

        Task<Tag> EditTag(int id, Tag tag);

        Task<bool> DeleteTag(int id);
    }
}