﻿namespace BlazorBlog.Shared.Services.Interfaces
{
    public interface ISlugService
    {
        string UrlFriendly(string title);

        bool IsUnique(string slug);
    }
}