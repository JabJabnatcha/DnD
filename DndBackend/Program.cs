
using Layer_Infrastructure;
using Microsoft.EntityFrameworkCore;
using Layer_Domain.Entities;          
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Builder;

var builder = WebApplication.CreateBuilder(args);

// ✅ Add DbContext
builder.Services.AddDbContext<DndDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// ✅ Add Controllers
builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.PropertyNameCaseInsensitive = true;
    });


// ✅ Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// ✅ Enable Swagger UI only in Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// ✅ ใช้ Authorization (ถ้ามี)
app.UseAuthorization(); // optional if you're using auth

// ✅ Map Controllers
app.MapControllers(); // <-- สำคัญมาก

app.Run();
