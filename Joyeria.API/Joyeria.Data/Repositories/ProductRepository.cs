using Joyeria.Core.Models;
using Joyeria.Core.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joyeria.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly JoyeriaDbContext _dbContext;

        public ProductRepository(JoyeriaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await this._dbContext.Products.ToListAsync();
        }
    }
}
