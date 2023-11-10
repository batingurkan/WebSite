using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Services;

namespace WebSite.ViewComponents.LayoutHeadComponents;

public class LayoutHeadComponent:ViewComponent
{
    
        private readonly ILogger<LayoutHeadComponent> _logger;
        private readonly IPageService _pageService;
        private readonly DataContext _dataContext;

        public LayoutHeadComponent(DataContext dataContext, ILogger<LayoutHeadComponent> logger,
            IPageService pageService)
        {
            _dataContext = dataContext;
            _logger = logger;
            _pageService = pageService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var page = await _dataContext.Page.ToListAsync();
            return View(page);
        }
    }
