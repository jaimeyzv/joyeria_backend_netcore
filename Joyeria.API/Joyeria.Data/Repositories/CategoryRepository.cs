using Joyeria.Core.Models;
using Joyeria.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joyeria.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly JoyeriaDbContext _dbContext;

        public CategoryRepository(JoyeriaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await this._dbContext.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            var category = await _dbContext.Categories.FindAsync(id);
            return category;
        }
    }
}
