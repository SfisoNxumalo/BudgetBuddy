using BudgetBuddyApp.Server.Entities;
using BudgetBuddyApp.Server.Interfaces.Repositories;
using BudgetBuddyApp.Server.Interfaces.Services;

namespace BudgetBuddyApp.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<CategoryEntity>> GetCategoriesByUserIdAsync(Guid userId)
        {
            return await _repository.GetCategoriesByUserIdAsync(userId);
        }

        public async Task<CategoryEntity> AddCategoryAsync(CategoryEntity category)
        {

            return await _repository.AddCategoryAsync(category);
        }

        public async Task<CategoryEntity?> GetCategoryByIdAsync(Guid categoryId)
        {
            return await _repository.GetCategoryByIdAsync(categoryId);
        }
    }
}
