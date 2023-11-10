using Microsoft.EntityFrameworkCore;
using WebSite.Entity;

namespace WebSite.Services;
public interface IAccountService
{
    Task<List<Admin>> Adminler();
    Task<Admin> Admin(int Id);
    
    Task<Admin> Admin(string Username, string Password);
}


public class AccountService : IAccountService
{
    private readonly DataContext _dataContext;
    private readonly ILogger<AccountService> _logger;

    public AccountService(DataContext dataContext, ILogger<AccountService> logger)
    {
        _dataContext = dataContext;
        _logger = logger;
    }
    public async Task<List<Admin>> Adminler()
    {
        return await _dataContext.Admin.ToListAsync();
    }

    public Task<Admin> Admin(int Id)
    {
        throw new NotImplementedException();
    }

    public Task<Admin> Admin(string Username, string Password)
    {
        throw new NotImplementedException();
    }
}