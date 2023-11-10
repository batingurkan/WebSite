using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebSite.Entity;
using WebSite.Services;
using Page = Microsoft.AspNetCore.Mvc.RazorPages.Page;

namespace WebSite.Controllers;

[AllowAnonymous]
public class AccountController : Controller
{
    private readonly IAccountService _accountService;
    private readonly ILogger<AccountController> _logger;
    private readonly DataContext _dataContext;

    public AccountController(ILogger<AccountController> logger, DataContext dataContext, IAccountService accountService)
    {
        _logger = logger;
        _dataContext = dataContext;
        _accountService = accountService;

    }


    [HttpGet]
    public IActionResult Loginadm()
    {

        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Loginadm(Admin admin)
    {
        var bilgiler = await _dataContext.Admin.FirstOrDefaultAsync(x => x.Username == admin.Username && x.Password == admin.Password);
        if (bilgiler != null )
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, admin.Username)
            };
            var useridentity = new ClaimsIdentity(claims, "Login");
            ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
            await HttpContext.SignInAsync(principal);
            return Redirect("../../Admin/");
        }

        return View();
    }

    [HttpGet]

    public async Task<IActionResult> Logout()
    {

        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        return RedirectToAction("Loginadm", "Account");
    }
}