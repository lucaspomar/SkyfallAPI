using Microsoft.EntityFrameworkCore;
using SkyfallAPI.Data;
using SkyfallAPI.Repositories.Interfaces;
using SkyfallAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SkyfallDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:DatabaseConnection"]);
});

builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
builder.Services.AddTransient<ISpellRepository, SpellRepository>();

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
