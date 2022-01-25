using Joyeria.Core;
using Joyeria.Core.Models;
using Joyeria.Core.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Joyeria.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            return await this._unitOfWork.Products.GetProductsAsync();
        }
    }
}
