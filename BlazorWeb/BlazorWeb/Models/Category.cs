using System.ComponentModel.DataAnnotations;

namespace BlazorWeb.Models;

public class Category
{
    [Key]
    public int Id { get; set; }
    [Required (ErrorMessage = "Fill the name")]
    public String Name { get; set; }
    public String Description { get; set; }

    public ICollection<Product> Products { get; set; } = new List<Product>();
}