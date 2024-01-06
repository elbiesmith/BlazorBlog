using BlazorBlog.Shared.Services.Interfaces;

namespace BlazorBlog.Shared.Services.Client
{
    public class SlugService : ISlugService
    {
        public bool IsUnique(string slug)
        {
            throw new NotImplementedException();
        }

        public string UrlFriendly(string title)
        {
            throw new NotImplementedException();
        }
    }
}