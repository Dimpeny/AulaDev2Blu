using NewsWebsiteExercise.Models;
using NewsWebsiteExercise.Models.Entities;

namespace NewsWebsiteExercise.Repositories
{
    public class CategoryRepository
    {
        private readonly DataBaseContext _context;

        public CategoryRepository(DataBaseContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Category>> GetAll()
        {
            return _context.Category.ToList();
        }

        public async Task<int> SaveCategory(Category category)
        {
            _context.Add(category);
            return await _context.SaveChangesAsync();
        }
    }
}
