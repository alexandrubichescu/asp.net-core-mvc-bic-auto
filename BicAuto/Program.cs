using BicAuto.Models;
using BicAuto.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IAutoRepository, AutoRepository>();  
builder.Services.AddControllersWithViews();
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();

builder.Services.AddDbContext<BicAutoDbContext>(options =>{
     
    options.UseSqlServer(
        
        builder.Configuration["ConnectionStrings:BicsAutoDbContextConnection"]);
});

var app = builder.Build();
app.UseStaticFiles();
if(app.Environment.IsDevelopment())
{
app.UseDeveloperExceptionPage();
}
app.UseSession();
app.MapDefaultControllerRoute();
DbInitializer.Seed(app);

app.Run();
