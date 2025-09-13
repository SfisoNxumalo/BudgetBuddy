using BudgetBuddyApp.Server.Data;
using BudgetBuddyApp.Server.DTOs.UserDTOs;
using BudgetBuddyApp.Server.Entities;
using BudgetBuddyApp.Server.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BudgetBuddyApp.Server.Repositories.UserRepository
{
    public class UserRepository : IUserRepository
    {
        private readonly BudgetBuddyContext _context;
        public UserRepository(BudgetBuddyContext context) {
            _context = context;
        }
        public async Task<List<ViewUserDTO>> GetUsersAsync()
        {
            return await _context.Users.Select(user => new ViewUserDTO
            {
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                CreatedAt = user.CreatedAt,
            }).ToListAsync();
        }
    }
}
