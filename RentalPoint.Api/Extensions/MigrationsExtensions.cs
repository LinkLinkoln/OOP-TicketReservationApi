using Microsoft.EntityFrameworkCore;
using TicketBookingApplication.Api;

public static class MigrationsExtensions
{
    public static void ApplyMigrations(this IApplicationBuilder app)
    {
        using IServiceScope scope = app.ApplicationServices.CreateScope();

        using ApplicationDbContext context = scope
            .ServiceProvider.GetService<ApplicationDbContext>();

        context.Database.Migrate();
    }
}