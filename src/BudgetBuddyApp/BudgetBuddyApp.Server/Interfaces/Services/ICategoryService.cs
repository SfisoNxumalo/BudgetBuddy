using BudgetBuddyApp.Server.DTOs;
using BudgetBuddyApp.Server.Entities;

namespace BudgetBuddyApp.Server.Interfaces.Services
{
    //I used ChatGpt to generate this Interface, I then modified it
    public interface ICategoryService
    {
        Task<List<CategoryEntity>> GetCategoriesByUserIdAsync(Guid userId);
        Task<CategoryEntity> AddCategoryAsync(AddCategoryDTO newCategory);
        Task<CategoryEntity?> GetCategoryByIdAsync(Guid categoryId);
    }
}
