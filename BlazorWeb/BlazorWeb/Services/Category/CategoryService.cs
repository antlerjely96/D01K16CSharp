namespace BlazorWeb.Services.Category;
using BlazorWeb.Data;
using Microsoft.EntityFrameworkCore;
using BlazorWeb.Models;
public class CategoryService : ICategoryService
{
    private readonly AppDbContext _context;
    
    //Constructor
    public CategoryService(AppDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Category>> GetAllCategoriesAsync()
    {
        return await _context.Categories.ToListAsync();
    }

    public async Task<Category> GetCategoryByIdAsync(int Id)
    {
        return await _context.Categories.FindAsync(Id);
    }

    public async Task CreateCategoryAsync(Category category)
    {
        _context.Categories.Add(category);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateCategoryAsync(Category category)
    {
        _context.Categories.Update(category);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteCategoryAsync(int Id)
    {
        var category = await _context.Categories.FindAsync(Id);
        _context.Categories.Remove(category);
        await _context.SaveChangesAsync();
    }
}