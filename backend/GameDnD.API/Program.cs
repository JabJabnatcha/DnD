using GameDnD.API.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddControllers();
builder.Services.AddDbContext<GameContext>(options =>
    options.UseSqlite("Data Source=game.db"));
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ---- เพิ่ม CORS ----
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy
            .WithOrigins("http://localhost:5173") // URL ของ Frontend
            .AllowAnyHeader()
            .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ---- เปิดใช้ CORS ก่อน MapControllers ----
app.UseCors();

app.UseAuthorization();

app.MapControllers();

app.Run();
