namespace BlazorEcommerce.Services.CategoryService;

public class CategoryService : ICategoryService
{
    private ApiService _apiService { get; set; }

    public CategoryService(ApiService apiService)
    {
        _apiService = apiService;
    }

    public async Task<IEnumerable<string>> GetCategoriesAsync()
    {
        return await _apiService.Get<IEnumerable<string>>("products/categories");
    }
}
