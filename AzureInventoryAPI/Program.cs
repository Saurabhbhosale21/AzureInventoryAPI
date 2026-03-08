using AzureInventoryAPI.Services;
using AzureInventoryAPI.Repositories;
using AzureInventoryAPI.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// -----------------------------
// Add services to the container
// -----------------------------

builder.Services.AddApplicationInsightsTelemetry();
builder.Services.AddControllers();

// Register DbContext
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    ));

// Register Repository Layer
builder.Services.AddScoped<IProductRepository, ProductRepository>();

// Register Service Layer
builder.Services.AddScoped<ProductService>();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


// -----------------------------
// Configure HTTP request pipeline
// -----------------------------

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();