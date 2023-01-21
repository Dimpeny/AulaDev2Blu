using NewsWebsiteExercise.Models.Entities;
using NewsWebsiteExercise.Repositories;
using NewsWebsiteExercise.Services.Interface;

namespace NewsWebsiteExercise.Services.Implements
{
    public class CategoryService : ICategoryService
    {
        public readonly CategoryRepository _repository;

        public CategoryService(CategoryRepository categoryRepository)
        {
            _repository = categoryRepository;
        }

        public async Task<IEnumerable<Category>> GetAllCategories()
        {
            return await _repository.GetAll();
        }

        public async Task<int> Save(Category category)
        {
            return await _repository.SaveCategory(category);
        }
    }
}
