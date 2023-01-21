using NewsWebsiteExercise.Models.Entities;

namespace NewsWebsiteExercise.Services.Interface
{
    public interface ICategoryService
    {
        Task<IEnumerable<Category>> GetAllCategories();
        Task<int> Save(Category category);
    }
}
