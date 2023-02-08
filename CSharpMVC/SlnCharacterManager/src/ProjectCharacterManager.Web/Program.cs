using Microsoft.EntityFrameworkCore;
using ProjectCharacterManager.Application.Service.SQLServerServices;
using ProjectCharacterManager.Domain.IRepositories;
using ProjectCharacterManager.Domain.IServices;
using ProjectCharacterManager.Infra.Data.Context;
using ProjectCharacterManager.Infra.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Add context
builder.Services.AddDbContext<SQLServerContext>
    (options => options.UseSqlServer("Server=LAPTOP-OG8VKPCG\\SQLEXPRESS;Database=CharacterManagerWebsite;User Id=sa;Password=admin;TrustServerCertificate=True;"));

//Add injections
builder.Services.AddScoped<IWorldRepository,WorldRepository>();
builder.Services.AddScoped<IWorldService,WorldService>();

builder.Services.AddScoped<ICharacterRepository, CharacterRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();


 builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
 builder.Services.AddScoped<INewsRepository, NewsRepository>();


builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<INewsService, NewsService>();

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

app.Run();
