using Microsoft.EntityFrameworkCore;
using Venta.BW.CU;
using Venta.BW.Interfaces.BW;
using Venta.BW.Interfaces.DA;
using Ventan.DA.Contexto;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<ContextoData>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("JesnerCS")));
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Inyección de dependencias
builder.Services.AddTransient<IGestionarVentaBW, GestionarVentaBW>();
builder.Services.AddTransient<IGestionarVentaDA, IGestionarVentaDA>();

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
