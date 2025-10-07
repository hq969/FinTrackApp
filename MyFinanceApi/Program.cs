using Microsoft.EntityFrameworkCore;
using MyFinanceApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// In-memory DB for sample
builder.Services.AddDbContext<ApplicationDbContext>(opt => opt.UseInMemoryDatabase("FinanceDb"));

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseAuthorization();
app.MapControllers();
app.Run();
