using ECommerceAPI.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Product_API.Models;

namespace ECommerceAPI.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;

        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpGet(Name = "")]
        public IEnumerable<Product> Get()
        {
            return _productService.Get();
        }
    }
}