using System.ComponentModel.DataAnnotations;

namespace WebSite.Entity;

public class Admin
{
    [Key]
    public int AdminID { get; set; }
    public string AdminName { get; set; }
    public string AdminPassword { get; set; }
}