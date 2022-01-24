using Joyeria.Core.Repositories;
using Joyeria.Core.Services;

namespace Joyeria.Services.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
    }
}
