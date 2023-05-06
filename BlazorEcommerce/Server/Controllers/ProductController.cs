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
    public async Task<ServiceResponse<List<Product>>> GetProduct()
    {
        return new ServiceResponse<List<Product>>()
        {
            Data = await this.context.Products.ToListAsync()
        };
    }
}