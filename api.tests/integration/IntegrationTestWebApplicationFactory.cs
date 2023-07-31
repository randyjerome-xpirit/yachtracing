using infrastructure.Database;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Data.Common;

namespace api.tests.integration;
public class IntegrationTestWebApplicationFactory<T> : WebApplicationFactory<T> where T : class
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(svcs =>
        {
            var db = svcs.SingleOrDefault(e => e.ServiceType == typeof(DbContextOptions<YachtDbContext>));
            if (db != null)
            {
                svcs.Remove(db);
            }

            var dbConn = svcs.SingleOrDefault(e => e.ServiceType == typeof(DbConnection));
            if (dbConn != null)
            {
                svcs.Remove(dbConn);
            }

            svcs.AddSingleton<DbConnection>(e =>
            {
                var connection = new SqliteConnection("DataSource=:memory:");
                connection.Open();

                return connection;
            });

            svcs.AddDbContext<YachtDbContext>((container, options) =>
            {
                var connection = container.GetRequiredService<DbConnection>();
                options.UseSqlite(connection);
            });
        });
        builder.UseEnvironment("Development");

    }
}
