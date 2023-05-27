var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
var app = builder.Build();

app.UseRouting();
app.UseStaticFiles();

// add IndexController
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Index}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();