using BlazorEcommerce.Models;

namespace BlazorEcommerce.Services.ProductService;

public interface IProductService
{
    public Task<IEnumerable<Product>> GetProductsAsync();
}
