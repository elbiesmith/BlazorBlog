using BlazorBlog.Shared.Models;
using BlazorBlog.Shared.Services.Interfaces;

namespace BlazorBlog.Shared.Services.Server
{
    public class TagService : ITagService
    {
        public Task<Tag> AddTag(Tag tag)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteTag(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Tag> EditTag(int id, Tag tag)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tag>> GetAllTags()
        {
            throw new NotImplementedException();
        }

        public Task<List<Post>> GetPostsByTagId(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Tag>> GetTagsByPostId(int id)
        {
            throw new NotImplementedException();
        }
    }
}