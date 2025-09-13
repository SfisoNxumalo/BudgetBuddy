using BudgetBuddyApp.Server.Data;
using BudgetBuddyApp.Server.DTOs.CategoryDTOs;
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

        public async Task<List<ViewCategoryDTO>> GetCategoriesByUserIdAsync(Guid userId)
        {
            return await _context.Categories.AsNoTracking()
                                 .Where(c => c.UserId.Equals(userId)).Select(category => new ViewCategoryDTO
                                 {
                                     Id = category.Id,
                                     Name = category.Name,
                                     UserId = category.UserId,
                                     CreatedAt = category.CreatedAt
                                 })
                                 .ToListAsync();
        }

        public async Task<CategoryEntity> AddCategoryAsync(CategoryEntity category)
        {
            _context.Categories.Add(category);
            await _context.SaveChangesAsync();
            return category;
        }

        public async Task<ViewCategoryDTO?> GetCategoryByIdAsync(Guid categoryId)
        {
            return await _context.Categories
                                 .AsNoTracking().Select(category => new ViewCategoryDTO
                                 {
                                     Id = category.Id,
                                     Name = category.Name,
                                     UserId = category.UserId,
                                     CreatedAt = category.CreatedAt
                                 })
                                 .FirstOrDefaultAsync(c => c.Id.Equals(categoryId));
        }
    }
}
