namespace BlazorEcommerce.Server.Services;

public class ProductService : IProductService
{
    private readonly DataContext context;

    public ProductService(DataContext context)
    {
        this.context = context;
    }
    
    public async Task<ServiceResponse<List<Product>>> GetProductsAsync() => 
        new ServiceResponse<List<Product>>()
        {
            Data = await context.Products.ToListAsync(),
        };
        
}