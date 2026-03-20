namespace BlazorWeb.Services.Category;
using BlazorWeb.Models;

public interface ICategoryService
{
    //Lay toan bo category
    Task<List<Category>> GetAllCategoriesAsync();
    //Lay 1 category theo id
    Task<Category> GetCategoryByIdAsync(int Id);
    //Tao 1 category
    Task CreateCategoryAsync(Category category);
    //Chinh sua 1 category
    Task UpdateCategoryAsync(Category category);
    //Xoa 1 category
    Task DeleteCategoryAsync(int Id);
}