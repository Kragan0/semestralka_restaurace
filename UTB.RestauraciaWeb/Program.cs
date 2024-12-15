using Microsoft.EntityFrameworkCore;
using UTB.Restauracia.Infrastructure.Database;
using UTB.Restauracia.Application.Abstraction;
using UTB.Restauracia.Application.Implementation;


var builder = WebApplication.CreateBuilder(args);

string connectionString = builder.Configuration.GetConnectionString("MySQL");
ServerVersion serverVersion = new MySqlServerVersion("8.0.38");
builder.Services.AddDbContext<RestauraciaDbContext>(optionsBuilder => optionsBuilder.UseMySql(connectionString, serverVersion));


// Add services to the container.
builder.Services.AddControllersWithViews();


builder.Services.AddScoped<IFoodAppService, FoodAppService>();

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
    name: "areas",
    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
