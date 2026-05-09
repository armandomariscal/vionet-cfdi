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

var runMigrations =
    builder.Configuration.GetValue<bool>("RUN_MIGRATIONS");

var runSeed =
    builder.Configuration.GetValue<bool>("RUN_SEED");

if (runMigrations || runSeed)
{
    using var scope = app.Services.CreateScope();

    var context =
        scope.ServiceProvider.GetRequiredService<AppDbContext>();

    if (runMigrations)
    {
        await context.Database.MigrateAsync();
    }

    if (runSeed)
    {
        await DbSeeder.SeedAsync(context);
    }
}

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