using Microsoft.EntityFrameworkCore;
using WebSite.Entity;

namespace WebSite.Services;


public interface ICompanyService
{
    Task<List<Company>> Companys();
    Task<Company> Company(int Id);
}

public class CompanyService : ICompanyService
{
    private readonly DataContext _dataContext;
    private readonly ILogger<CompanyService> _logger;

    public CompanyService(DataContext dataContext,ILogger<CompanyService> logger)
    {
        _dataContext = dataContext;
        _logger = logger;
    }

    public async Task<List<Company>> Companys()
    {
        return await _dataContext.Company.ToListAsync();
    }
    
    public async Task<Company> Company(int Id)
    {
        return await _dataContext.Company.FirstOrDefaultAsync(s=> s.Id == Id);
    }

    
    
}