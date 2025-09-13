using BudgetBuddyApp.Server.DTOs.UserDTOs;
using BudgetBuddyApp.Server.Entities;

namespace BudgetBuddyApp.Server.Interfaces.Services
{
    public interface IUserService
    {
        Task<List<ViewUserDTO>> GetUsersAsync();
    }
}
