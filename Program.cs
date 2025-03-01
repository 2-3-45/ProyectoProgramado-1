using Microsoft.EntityFrameworkCore;
using ProyectoProgramado_1.Data;

var builder = WebApplication.CreateBuilder(args);

// Configurar la conexi�n a la base de datos
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// Agregar controladores con vistas
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configuraci�n del middleware
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

// Configuraci�n de rutas
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
