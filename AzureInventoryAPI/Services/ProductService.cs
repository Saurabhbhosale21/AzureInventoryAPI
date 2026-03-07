using AzureInventoryAPI.Models;

namespace AzureInventoryAPI.Services
{
    public class ProductService
    {
        private static List<Product> products = new List<Product>()
        {
            new Product { Id = 1, Name = "Laptop", Price = 50000 },
            new Product { Id = 2, Name = "Mouse", Price = 500 }
        };

        public List<Product> GetProducts()
        {
            return products;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
    }
}