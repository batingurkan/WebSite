using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Services;

namespace WebSite.Views.Shared.LayoutComponents;

public class LayoutComponent : ViewComponent
{
    private readonly ILogger<LayoutComponent> _logger;
    private readonly ICompanyService _companyService;
    private readonly DataContext _dataContext;

    public LayoutComponent(ICompanyService companyService, DataContext dataContext, ILogger<LayoutComponent> logger)
    {
        _companyService = companyService;
        _dataContext = dataContext;
        _logger = logger;
    }

    public  async Task<IViewComponentResult> InvokeAsync()
    {
        var company = await _dataContext.Company.FirstOrDefaultAsync();
        return View(company);
    }
    
   
    
}