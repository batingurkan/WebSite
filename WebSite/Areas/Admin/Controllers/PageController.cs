using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Entity;

namespace WebSite.Areas.Admin.Controllers;

[Area("Admin")]
public class PageController : Controller
{
    private readonly ILogger<PageController> _logger;
    private readonly DataContext _dataContext;

    public PageController(ILogger<PageController> logger, DataContext dataContext)
    {
        _logger = logger;
        _dataContext = dataContext;
    }

    public async Task<IActionResult> Index()
    {
        var liste = await _dataContext.Sayfa.ToListAsync();
        return View(liste);
    }

    [HttpPost]
    public async Task<IActionResult> Add(Sayfa model)
    {
        await _dataContext.Sayfa.AddAsync(model);
        await _dataContext.SaveChangesAsync();
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public async Task<IActionResult> Update(Sayfa model)
    {
        var page = await _dataContext.Sayfa.Where(s=> s.Id == model.Id).FirstOrDefaultAsync();
        if (page != null)
        {
            page.Description = model.Description;
            page.Name = model.Name;
            _dataContext.Sayfa.Update(page);
            await _dataContext.SaveChangesAsync();
        }
        return RedirectToAction("Index");
    }
}