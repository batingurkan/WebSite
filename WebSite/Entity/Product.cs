using System.ComponentModel.DataAnnotations;

namespace WebSite.Entity;

public class Product
{
    [Key]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Image { get; set; }
    
}