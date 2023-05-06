using BlazorEcommerce.Shared;

namespace BlazorEcommerce.Client.Services;

public interface IProductService
{
    Task GetProducts();
    List<Product> Products { get; set; }
}