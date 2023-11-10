using System.ComponentModel.DataAnnotations;

namespace WebSite.Entity;

public class Admin
{
    [Key]
    public int Id { get; set; }
    public string Username { get; set; }
    public string Password { get; set; }
    public string IsActive { get; set; }
}