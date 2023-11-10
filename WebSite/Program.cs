using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using WebSite;
using WebSite.Entity;
using WebSite.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(x =>
{
    x.LoginPath = "/Account/Loginadm/";
});




var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContextPool<DataContext>(options =>
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Add services to the container.
var mvcBuilder = builder.Services.AddControllersWithViews();

if (builder.Environment.IsDevelopment())
    mvcBuilder.AddRazorRuntimeCompilation();

builder.Services.AddTransient<IPageService, PageService>();
builder.Services.AddTransient<ICompanyService, CompanyService>();
builder.Services.AddTransient<IAccountService, AccountService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "area",
    pattern: "{area=exists}/{controller=Home}/{action=Index}/{id?}");

app.Run();