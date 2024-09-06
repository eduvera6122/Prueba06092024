using Microsoft.EntityFrameworkCore;
using WebAPI__Eduardo_Vera_20240906.Models;
using WebAPI__Eduardo_Vera_20240906.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

// Configuración de CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAngularClient", builder =>
    {
        builder.WithOrigins("http://localhost:4200") // Cambia al dominio de tu aplicación Angular
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});


builder.Services.AddControllers();






builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IUsuarioService, UsuarioService>();
builder.Services.AddScoped<ISolicitudService, SolicitudService>();
builder.Services.AddScoped<IPrestamoService, PrestamoService>();
builder.Services.AddScoped<IPagoService, PagoService>();




builder.Services.AddDbContext<Prueba06092024Context>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("conn"));
});


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// Activar CORS
app.UseCors("AllowAngularClient");

app.UseAuthorization();

app.MapControllers();

app.Run();
