using Microsoft.EntityFrameworkCore;
using TestingFundamentalsApi.Data;

namespace TestingFundamentalsApi.Extensions;

internal static class ApiExtensions
{
    public static void AddDependencies(this IServiceCollection services)
    {
        services.AddDbContext<AppDbContext>(options =>
        {
            options.UseSqlite("DataSource=testing.db");
        });
    }

    public static void InitializeDatabase(this IApplicationBuilder app)
    {
        var scope = app.ApplicationServices.CreateScope();
        var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
        context.Database.OpenConnection();
        context.Database.EnsureCreated();
    }
}