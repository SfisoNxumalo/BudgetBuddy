using BudgetBuddyApp.Server.Entities;
using BudgetBuddyApp.Server.Interfaces.Repositories;
using BudgetBuddyApp.Server.Interfaces.Services;

namespace BudgetBuddyApp.Server.Services.UserService
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _repo;
        public UserService(IUserRepository repo) {
            _repo = repo;
        }
        public async Task<List<UserEntity>> GetUsersAsync()
        {
           return await _repo.GetUsersAsync();
        }
    }
}
