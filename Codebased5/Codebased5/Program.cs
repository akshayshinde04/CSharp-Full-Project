using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Codebased5.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<Codebased5Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("Codebased5Context") ?? throw new InvalidOperationException("Connection string 'Codebased5Context' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
