using Microsoft.EntityFrameworkCore;
using SportShop.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<StoreDbContext>(opts =>
{
    opts.UseSqlServer(builder.Configuration["ConnectionStrings:SportShopConnection"]);
});
builder.Services.AddScoped<IStoreRepository,EFStroryRepository>();
builder.Services.AddRazorPages();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession();
var app = builder.Build();


app.UseStaticFiles();
app.UseSession();

app.MapControllerRoute("catpage", "{category}/Page{productPage:int}",
    new { Controller = "Home",action = "Index"});
app.MapControllerRoute("page", "Page{productPage:int}",
    new { Controller = "Home", action = "Index",productPage=1});
app.MapControllerRoute("category", "{category}",
    new { Controller = "Home", action = "Index", productPage = 1});
app.MapControllerRoute("pagination","Products/Page{productPage}",
    new {Controller="Home",action="Index",productPage = 1});

//app.UseRouting();

app.UseAuthorization();

app.MapDefaultControllerRoute();
app.MapRazorPages();
//SeedData.Change(app);
app.Run();
