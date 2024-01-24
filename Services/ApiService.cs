using Newtonsoft.Json;

namespace BlazorEcommerce.Services;

public class ApiService
{
    private readonly HttpClient _httpClient;

    public ApiService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<T> Get<T>(string endpoint)
    {
        var response = await _httpClient.GetAsync(endpoint);

        if (response.IsSuccessStatusCode)
        {
            var responseStream = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(responseStream);
        }

        return default(T);
    }
}
