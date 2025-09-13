using BudgetBuddyApp.Server.Entities;

namespace BudgetBuddyApp.Server.Interfaces.Services
{
    public interface IUserService
    {
        Task<List<UserEntity>> GetUsersAsync();
    }
}
