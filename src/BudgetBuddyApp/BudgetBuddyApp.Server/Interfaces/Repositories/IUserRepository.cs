using BudgetBuddyApp.Server.DTOs.UserDTOs;
using BudgetBuddyApp.Server.Entities;

namespace BudgetBuddyApp.Server.Interfaces.Repositories
{
    public interface IUserRepository
    {
        Task<List<ViewUserDTO>> GetUsersAsync();
    }
}
