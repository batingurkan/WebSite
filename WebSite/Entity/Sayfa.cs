using System.ComponentModel.DataAnnotations;

namespace WebSite.Entity;

public class Sayfa
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; }
    public string Description { get; set; }
}