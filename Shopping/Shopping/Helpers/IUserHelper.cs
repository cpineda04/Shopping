using Microsoft.AspNetCore.Identity;
using Shopping.Data.Entities;
using Shopping.Models;

namespace Shopping.Helpers
{
    public interface IUserHelper
    {
        public interface IUserHelper
        {
            Task<User> GetUserAsync(string email);

            Task<IdentityResult> AddUserAsync(User user, string password);

            Task CheckRoleAsync(string roleName);

            Task AddUserToRoleAsync(User user, string roleName);

            Task<bool> IsUserInRoleAsync(User user, string roleName);
        }

        Task CheckRoleAsync(string v);
        Task<User> GetUserAsync(string email);
        Task AddUserAsync(User user, string v);
        Task AddUserToRoleAsync(User user, string v);
        Task<SignInResult> LoginAsync(LoginViewModel model);

        Task LogoutAsync();

    }
}
