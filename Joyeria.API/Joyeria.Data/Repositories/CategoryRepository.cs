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

        //private JoyeriaDbContext JoyeriaDbContext
        //{
        //    get { return _dbContext as JoyeriaDbContext; }
        //}

        public CategoryRepository(JoyeriaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<IEnumerable<Category>> GetCategoriesAsync()
        {
            return await this._dbContext.Categories.ToListAsync();
        }
    }
}
