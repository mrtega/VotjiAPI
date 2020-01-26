using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VotjiAPI.Domain;

namespace VotjiAPI.Services
{
    public interface IIdentityService 
    {
        Task<AuthenticationResult> RegisterAsync(string email, string password);
    }
}
