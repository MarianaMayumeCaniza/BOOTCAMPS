using WebApplication1.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicionar serviços ao contêiner.
builder.Services.AddDbContext<AgendaContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("ConexaoPadrao")));

builder.Services.AddControllers();
// Saiba mais sobre como configurar Swagger/OpenAPI em https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure o pipeline de solicitação HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
