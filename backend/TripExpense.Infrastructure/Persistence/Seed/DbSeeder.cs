using TripExpense.Domain.Entities;

namespace TripExpense.Infrastructure.Persistence.Seed;

public static class DbSeeder
{
    public static async Task SeedAsync(AppDbContext context)
    {
        if (context.Employees.Any())
            return;

        var employees = new List<Employee>
        {
            new()
            {
                Id = Guid.NewGuid(),
                FullName = "John Doe",
                Email = "john@example.com",
                Department = "Finance"
            },
            new()
            {
                Id = Guid.NewGuid(),
                FullName = "Jane Smith",
                Email = "jane@example.com",
                Department = "Operations"
            }
        };

        context.Employees.AddRange(employees);

        await context.SaveChangesAsync();
    }
}