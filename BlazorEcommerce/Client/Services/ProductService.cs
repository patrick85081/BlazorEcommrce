using System.Net.Http.Json;
using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services;

public class ProductService : IProductService
{
    private readonly HttpClient httpClient;

    public ProductService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
    }

    public async Task GetProducts()
    {
        var result = await httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("/api/Product");
        if (result.Success && result.Data != null)
            Products = result.Data;
    }

    public List<Product> Products { get; set; }
}