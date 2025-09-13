using BudgetBuddyApp.Server.DTOs.CategoryDTOs;
using BudgetBuddyApp.Server.Entities;

namespace BudgetBuddyApp.Server.Interfaces.Services
{
    //I used ChatGpt to generate this Interface, I then modified it
    public interface ICategoryService
    {
        Task<List<ViewCategoryDTO>> GetCategoriesByUserIdAsync(Guid userId);
        Task<CategoryEntity> AddCategoryAsync(AddCategoryDTO newCategory);
        Task<ViewCategoryDTO> GetCategoryByIdAsync(Guid categoryId);
    }
}
