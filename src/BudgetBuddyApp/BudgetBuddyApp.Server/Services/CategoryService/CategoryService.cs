using BudgetBuddyApp.Server.Entities;
using BudgetBuddyApp.Server.Interfaces.Repositories;
using BudgetBuddyApp.Server.Interfaces.Services;

namespace BudgetBuddyApp.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository, Logger<CategoryService> logger)
        {
            _repository = repository;
        }

        public async Task<List<CategoryEntity>> GetCategoriesByUserIdAsync(Guid userId)
        {
            try
            {
                return await _repository.GetCategoriesByUserIdAsync(userId);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public async Task<CategoryEntity> AddCategoryAsync(CategoryEntity category)
        {
            try
            {
                return await _repository.AddCategoryAsync(category);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }

        public async Task<CategoryEntity?> GetCategoryByIdAsync(Guid categoryId)
        {
            try
            {
                return await _repository.GetCategoryByIdAsync(categoryId);
            }
            catch (Exception ex)
            {
                throw;
            }
            
        }
    }
}
