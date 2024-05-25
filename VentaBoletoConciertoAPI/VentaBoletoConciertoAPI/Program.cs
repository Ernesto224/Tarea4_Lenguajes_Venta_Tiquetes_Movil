using Microsoft.EntityFrameworkCore;
using Venta.BC.Constantes;
using Venta.BW.CU;
using Venta.BW.Interfaces.BW;
using Venta.BW.Interfaces.DA;
using Venta.DA.Acciones;
using Ventan.DA.Contexto;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ContextoData>(options =>
options.UseSqlServer(StringDeConexion.stringDeConexion));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyección de dependencias
builder.Services.AddTransient<IGestionarTipoZonaBW, GestionarTipoZonaBW>();
builder.Services.AddTransient<IGestionarTipoZonaDA, GestionarTipoZonaDA>();
builder.Services.AddTransient<IGestionarUsuarioBW, GestionarUsuarioBW>();
builder.Services.AddTransient<IGestionarUsuarioDA, GestionarUsuarioDA>();
builder.Services.AddTransient<IGestionarConciertoBW, GestionarConciertoBW>();
builder.Services.AddTransient<IGestionarConciertoDA, GestionarConciertoDA>();
builder.Services.AddTransient<IGestionarAsientosBW, GestionarAsientoBW>();
builder.Services.AddTransient<IGestionarAsientosDA, GestionarAsientosDA>();
builder.Services.AddTransient<IGestionarReservaBW, GestionarReservaBW>();
builder.Services.AddTransient<IGestionarReservaDA, GestionarReservaDA>();



var app = builder.Build();
app.UseCors("AllowOrigin");
app.UseCors(options =>
{
    options.AllowAnyOrigin();
    options.AllowAnyMethod();
    options.AllowAnyHeader();
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
