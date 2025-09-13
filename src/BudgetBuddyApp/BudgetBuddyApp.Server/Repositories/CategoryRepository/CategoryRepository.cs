using BudgetBuddyApp.Server.Data;
using BudgetBuddyApp.Server.Entities;
using BudgetBuddyApp.Server.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;

namespace BudgetBuddyApp.Server.Repositories.CategoryRepository
{
    //I used ChatGpt to generate this repository, I then modified it based on my requirements
    public class CategoryRepository : ICategoryRepository
    {
        private readonly BudgetBuddyContext _context;

        public CategoryRepository(BudgetBuddyContext context)
        {
            _context = context;
        }

        public async Task<List<CategoryEntity>> GetCategoriesByUserIdAsync(Guid userId)
        {
            return await _context.Categories
                                 .AsNoTracking()
                                 .Where(c => c.UserId.Equals(userId))
                                 .ToListAsync();
        }

        public async Task<CategoryEntity> AddCategoryAsync(CategoryEntity category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<CategoryEntity?> GetCategoryByIdAsync(Guid categoryId)
        {
            return await _context.Categories
                                 .AsNoTracking()
                                 .FirstOrDefaultAsync(c => c.Id.Equals(categoryId));
        }
    }
}
