using Microsoft.EntityFrameworkCore;
using WebSite.Entity;

namespace WebSite.Services;

public interface IPageService
{
    Task<List<Page>> Sayfalar();
    Task<Page> Sayfa(int Id);
}

public class PageService : IPageService
{
    private readonly DataContext _dataContext;
    private readonly ILogger<PageService> _logger;

    public PageService(DataContext dataContext,ILogger<PageService> logger)
    {
        _dataContext = dataContext;
        _logger = logger;
    }

    public async Task<List<Page>> Sayfalar()
    {
        return await _dataContext.Page.OrderBy(s=> s.PageSortingIndex).ToListAsync();
    }
    
    public async Task<Page> Sayfa(int Id)
    {
        return await _dataContext.Page.FirstOrDefaultAsync(s=> s.Id == Id);
    }
    
}