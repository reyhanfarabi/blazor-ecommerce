using BlazorEcommerce.Components;
using BlazorEcommerce.Services;
using BlazorEcommerce.Services.CategoryService;
using BlazorEcommerce.Services.CurrencyService;
using BlazorEcommerce.Services.ProductService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("https://fakestoreapi.com/")
});
builder.Services.AddHttpClient();
builder.Services.AddTransient<ApiService>();
builder.Services.AddTransient<ProductService>();
builder.Services.AddTransient<CategoryService>();
builder.Services.AddTransient<CurrencyService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
