using Joyeria.API.ViewModels;
using Joyeria.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace Joyeria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            try
            {
                var products = await this._productService.GetProductsAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message});
            }
        }

        [HttpPost]
        public IActionResult Create([FromBody]ProductVM product)
        {
            try
            {
                return Ok(product);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
