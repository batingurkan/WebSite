using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebSite.Areas.Admin.Controllers;

[Area("Admin")]
public class PageController : Controller
{ 
    private readonly ILogger<PageController> _logger;
    private readonly DataContext _dataContext;

    public PageController(ILogger<PageController> logger,DataContext dataContext)
    {
        _logger = logger;
        _dataContext = dataContext;
    }
    
    public async Task<IActionResult> Index()
    {
        var liste = await _dataContext.Sayfa.ToListAsync();
        return View(liste);
    }
}