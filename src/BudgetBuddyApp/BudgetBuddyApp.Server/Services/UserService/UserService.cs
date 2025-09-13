using BudgetBuddyApp.Server.DTOs.UserDTOs;
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
        public async Task<List<ViewUserDTO>> GetUsersAsync()
        {
           return await _repo.GetUsersAsync();
        }
    }
}
