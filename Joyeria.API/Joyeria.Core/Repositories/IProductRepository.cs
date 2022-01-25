using Joyeria.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joyeria.Core.Repositories
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}
