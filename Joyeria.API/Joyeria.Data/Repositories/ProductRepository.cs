using Joyeria.Core.Repositories;

namespace Joyeria.Data.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly JoyeriaDbContext _dbContext;

        //private JoyeriaDbContext JoyeriaDbContext
        //{
        //    get { return _dbContext as JoyeriaDbContext; }
        //}

        public ProductRepository(JoyeriaDbContext dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
