using Microsoft.EntityFrameworkCore;
using SkyfallAPI.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SkyfallDbContext>(options =>
{
    options.UseInMemoryDatabase("SkyfallDatabase");
});
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
