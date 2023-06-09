using HackathonLoginApp.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// Configures the application to use a SQL Server Database.
var dbConnectionString = builder.Configuration.GetConnectionString("localDatabase");
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(dbConnectionString));

// Configures the application for HTTP Sessions.
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.Cookie.Name = ".HackathonFundacionEsplaiIvanMorenoPerez.Session";
    options.IdleTimeout = TimeSpan.FromSeconds(300);
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();
app.UseSession();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "users",
    pattern: "{controller=Users}/{action=Index}/{id?}");

app.Run();
