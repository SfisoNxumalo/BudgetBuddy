using BudgetBuddyApp.Server.Entities;

namespace BudgetBuddyApp.Server.Interfaces.Repositories
{
    //This interface was created using ChatGPT, but was modified
    public interface ICategoryRepository
    {
        Task<List<CategoryEntity>> GetCategoriesByUserIdAsync(Guid userId);
      
        Task<CategoryEntity> AddCategoryAsync(CategoryEntity category);

        Task<CategoryEntity?> GetCategoryByIdAsync(Guid categoryId);
    }
}
