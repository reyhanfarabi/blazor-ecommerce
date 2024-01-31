using BlazorEcommerce.Models;

namespace BlazorEcommerce.Services.ProductService;

public interface IProductService
{
    public Task<IEnumerable<Product>> GetProductsAsync();
    public Task<IEnumerable<Product>> GetProductsByCategoryAsync(string category);
    public Task<Product> GetProduct(string productId);
}
