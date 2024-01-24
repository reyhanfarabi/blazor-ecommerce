using BlazorEcommerce.Models;

namespace BlazorEcommerce.Services.ProductService;

public class ProductService : IProductService
{
    private ApiService _apiService { get; set; }

    public ProductService(ApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        return await _apiService.Get<IEnumerable<Product>>("products");
    }
}
