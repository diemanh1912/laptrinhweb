var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages().AddRazorRuntimeCompilation();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
    name: "Trang-Chu",
    pattern: "Trang-Chu/{action=Index}/{id?}",
    defaults: new { Controller = "Home", Action = "Index" });
app.MapControllerRoute(
    name: "Gioi-Thieu-Nhom",
    pattern: "Gioi-Thieu-Nhom/{action=Index}/{id?}",
    defaults: new { Controller = "Nhom_NoName", Action = "Index" });
app.Run();
