using System.ComponentModel.DataAnnotations;

namespace WebSite.Entity;

public class Company
{
    [Key]
    public int Id { get; set; }
    public string Logo { get; set; }
    public string Name { get; set; }
    public string Mail { get; set; }
    public string Telephone { get; set; }
    public string Telephone2 { get; set; }
    public string Adress { get; set; }
    public string Facebook { get; set; }
    public string Instagram { get; set; }
    public string Twitter { get; set; }
    public string B2B { get; set; }
    
    
    
}