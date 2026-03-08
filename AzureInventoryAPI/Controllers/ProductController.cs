using Microsoft.AspNetCore.Mvc;
using AzureInventoryAPI.Services;
using AzureInventoryAPI.DTOs;
using AzureInventoryAPI.Models;

namespace AzureInventoryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ProductService _productService;

        public ProductController(ProductService productService)
        {
            _productService = productService;
        }

        // GET: api/Product
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }

        // POST: api/Product
        [HttpPost]
        public IActionResult AddProduct(ProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Price = dto.Price
            };

            var result = _productService.AddProduct(product);

            return Ok(result);
        }
    }
}