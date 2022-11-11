using Microsoft.EntityFrameworkCore;
using imparviagem.imparBD;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionStringMysql =
    builder.Configuration.GetConnectionString("ConnectionMysql");
builder.Services.AddDbContext<ImparContext>(options => options.UseMySql(
    connectionStringMysql, ServerVersion.AutoDetect(connectionStringMysql)));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

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
