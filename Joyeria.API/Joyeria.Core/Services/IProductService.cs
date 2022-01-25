using Joyeria.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joyeria.Core.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetProductsAsync();
    }
}
