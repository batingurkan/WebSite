using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Entity;

namespace WebSite.Areas.Admin.Controllers;

[Area("Admin")]

[Authorize]
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
        var liste = await _dataContext.Page.ToListAsync();
        return View(liste);
    }
    
    
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpGet]
    public IActionResult Add()
    {
        return View();
    }


    [HttpPost]
    public async Task<IActionResult> Add(Page model)
    {
        await _dataContext.Page.AddAsync(model);
        await _dataContext.SaveChangesAsync();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int Id)
    {
        var sayfa = await _dataContext.Page.Where(s=> s.Id == Id).FirstOrDefaultAsync();
        return View(sayfa);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(Page model)
    {
        if (!ModelState.IsValid)
            return View(model);
        
        var page = await _dataContext.Page.Where(s=> s.Id == model.Id).FirstOrDefaultAsync();
        if (page != null)
        {
            page.Description = model.Description;
            page.Name = model.Name;
            _dataContext.Page.Update(page);
            await _dataContext.SaveChangesAsync();
        }
        return View(page);
    }
  
    public async Task<IActionResult> Delete(int id)
    { 
        var sayfa = await _dataContext.Page.Where(s=> s.Id == id).FirstOrDefaultAsync();
        _dataContext.Page.Remove(sayfa);
        await _dataContext.SaveChangesAsync();
        return RedirectToAction("Index","Page");
    }

   
}