using BudgetBuddyApp.Server.Data;
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
        public async Task<List<UserEntity>> GetUsersAsync()
        {
            return await _context.Users.ToListAsync();
        }
    }
}
