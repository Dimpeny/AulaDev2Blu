using Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Models;
using Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Repository;
using Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Services.Implements;
using Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

//Entityframework
builder.Services.AddDbContext<ContextoDatabase>
    (options => options.UseSqlServer("Server=LAPTOP-OG8VKPCG\\SQLEXPRESS;Database=AulaListaCompras;User Id=sa;Password=admin;"));

/*
 Dependency injection
 */
//Repositories
builder.Services.AddScoped<CategoriaRepository>();

//Services
builder.Services.AddScoped<ICategoriaService, CategoriaService>();

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
