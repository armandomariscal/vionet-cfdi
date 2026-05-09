using Microsoft.EntityFrameworkCore;
using TripExpense.Infrastructure.Persistence;
using TripExpense.Infrastructure.Persistence.Seed;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddOpenApi();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("DefaultConnection")
    )
);

var app = builder.Build();

using var scope = app.Services.CreateScope();

var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();

await context.Database.MigrateAsync();

await DbSeeder.SeedAsync(context);

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.MapGet("/api/employees", async (AppDbContext db) =>
{
    var employees = await db.Employees.ToListAsync();

    return Results.Ok(employees);
});

app.Run();