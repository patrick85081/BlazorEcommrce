using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly DataContext context;

    public ProductController(DataContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public Task<List<Product>> GetProduct()
    {
        return this.context.Products.ToListAsync();
    }
}