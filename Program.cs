using harakiri_rpg.Services.Interfaces;
using harakiri_rpg.Services;
using Microsoft.EntityFrameworkCore;
using System;
using harakiri_rpg.Models.DB;
using Microsoft.AspNetCore.Authentication.Cookies;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

DotNetEnv.Env.Load();

// Configurar autenticação com cookies
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Login/Index"; // Página de login
        options.LogoutPath = "/Login/Logout"; // Página de logout
        options.ExpireTimeSpan = TimeSpan.FromDays(7); // Expiração do cookie
        options.SlidingExpiration = true; // Renovação automática do cookie
    });


var connectionString = Environment.GetEnvironmentVariable("CONNECTION_STRING");

// Para funcionar rodando o docker, seguir estes passos? 
//https://forums.docker.com/t/container-cannot-connect-to-the-hosts-mysql-database/3493/5
//testar se funciona conectar em banco remoto rodando no docker

// Nao funciona conectar em banco localmente/localhost rodando no docker, so no http/https
builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(connectionString,
    ServerVersion.AutoDetect(connectionString)));

// Registro de serviços customizados
builder.Services.AddScoped<IUsuarioService, UsuarioService>();

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
