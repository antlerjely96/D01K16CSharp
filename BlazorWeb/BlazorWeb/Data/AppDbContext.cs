using BlazorWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWeb.Data;

public class AppDbContext : DbContext
{
    //Constructor
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }
    
    public DbSet<Category> Categories { get; set; }

    //Merge model voi bang trong db
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>(entity =>
            {
                //Merge model voi bang
                entity.ToTable("categories");
                //primary key
                entity.HasKey(e => e.Id);
                //Merge attr voi column
                entity.Property(e => e.Name).HasColumnName("name");
                entity.Property(e => e.Description).HasColumnName("description");
            }
        );
    }
}