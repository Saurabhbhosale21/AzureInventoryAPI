using AzureInventoryAPI.Models;

namespace AzureInventoryAPI.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetAllProducts();
        Product AddProduct(Product product);
    }
}