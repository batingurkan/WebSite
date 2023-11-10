using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Services;


namespace WebSite.Controllers;

public class PageController : Controller
{
    private readonly ILogger<PageController> _logger;
    private readonly IPageService _pageService;
    private readonly DataContext _dataContext;

    public PageController(ILogger<PageController> logger,IPageService pageService, DataContext dataContext)
    {
        _logger = logger;
        _pageService = pageService;
        _dataContext = dataContext;
    }

    public async Task<IActionResult> Index(int Id)
    {
        var currentPage = await _dataContext.Page.AsNoTracking().Where(s => s.Id == Id).FirstOrDefaultAsync();
        return View(currentPage);
    }
}