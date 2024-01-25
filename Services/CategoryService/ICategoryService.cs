namespace BlazorEcommerce.Services.CategoryService;

public interface ICategoryService
{
    public Task<IEnumerable<string>> GetCategoriesAsync();
}
