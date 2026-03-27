namespace BlazorWeb.Services.Product;
using Models;
public interface IProductService
{
    //Lay toan bo
    Task<List<Product>> GetAllProductAsync();
    //Lay theo ID
    Task<Product> GetProductByIdAsync(int Id);
    //Them
    Task CreateProductAsync(Product product);
    //Sua
    Task UpdateProductAsync(Product product);
    //Xoa
    Task DeleteProductAsync(int Id);
}