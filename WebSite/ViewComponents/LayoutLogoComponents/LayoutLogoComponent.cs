using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Services;

namespace WebSite.ViewComponents.LayoutLogoComponents;

public class LayoutLogoComponent : ViewComponent
{
    private readonly ILogger<LayoutLogoComponent> _logger;
    private readonly ICompanyService _companyService;
    private readonly DataContext _dataContext;

    public LayoutLogoComponent(ICompanyService companyService, DataContext dataContext, ILogger<LayoutLogoComponent> logger)
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