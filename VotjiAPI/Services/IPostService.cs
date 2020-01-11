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
        List<Post> GetPosts();
        Post GetPostById(Guid postId);

        bool UpdatePost(Post postToUpdate);

        bool DeletePost(Guid postId);


    }
}
