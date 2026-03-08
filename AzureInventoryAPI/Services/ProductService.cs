using AzureInventoryAPI.Models;
using AzureInventoryAPI.Repositories;

namespace AzureInventoryAPI.Services
{
    public class ProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public List<Product> GetProducts()
        {
            return _repository.GetAllProducts();
        }

        public Product AddProduct(Product product)
        {
            return _repository.AddProduct(product);
        }
    }
}