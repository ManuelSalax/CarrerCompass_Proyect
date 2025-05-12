
using Microsoft.EntityFrameworkCore;
using CarrerCompass_Proyect.Domain.Interfaces;
using CarrerCompass_Proyect.Infrastucture.Repositories;
using CarrerCompass_Proyect.Infrastucture.DbData;
using CarrerCompass_Proyect.Application.Services;

var builder = WebApplication.CreateBuilder(args);

// 🔧 Configuración de servicios
builder.Services.AddControllersWithViews();

// 📦 Configurar DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 🔌 Registrar Repositorios del dominio
builder.Services.AddScoped<IEstudianteRepositorio, EstudianteRepositorio>();
builder.Services.AddScoped<ITestVocacionalRepositorio, TestVocacionalRepositorio>();
builder.Services.AddScoped<ICarreraRepositorio, CarreraRepositorio>();
builder.Services.AddScoped<ICarreraSugeridaRepositorio, CarreraSugeridaRepositorio>();


builder.Services.AddScoped<EstudianteService>();
builder.Services.AddScoped<TestVocacionalService>();
builder.Services.AddScoped<CarreraService>();

// 🛠️ Construir la app
var app = builder.Build();

// 🌐 Middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// 🧭 Ruta por defecto
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
