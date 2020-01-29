using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotjiAPI.Contracts.V1;
using VotjiAPI.Domain;

namespace VotjiAPI.Services
{
    public interface IPostService
    {
        Task<List<Post>> GetPostsAsync();

        Task<Post> GetPostByIdAsync(Guid postId);

        Task<bool> CreatePostAsync(Post post);

        Task<bool> UpdatePostAsync(Post postToUpdate);

        Task<bool> DeletePostAsync(Guid postId);
        Task<bool> UserOwnsPostAsync(Guid postId, string userId);
    }
}
