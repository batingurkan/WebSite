using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebSite.Controllers;

public class PageController : Controller
{
    private readonly ILogger<PageController> _logger;
    private readonly DataContext _dataContext;

    public PageController(ILogger<PageController> logger, DataContext dataContext)
    {
        _logger = logger;
        _dataContext = dataContext;
    }

    public async Task<IActionResult> Index(int Id)
    {
        var currentPage = await _dataContext.Sayfa.AsNoTracking().Where(s => s.Id == Id).FirstOrDefaultAsync();
        return View(currentPage);
    }
    
    public IActionResult Hakkimizda()
    {
        return View();
    }
    public IActionResult Tedarikcilerimiz()
    {
        return View();
    }
    public IActionResult Iletisim()
    {
        return View();
    }
    public IActionResult Bayibasvuru()
    {
        return View();
    }


}