using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SchoolAppCoreMVC.Models
{
    public class SchoolContextFactory : IDesignTimeDbContextFactory<SchoolContext>
    {
        public SchoolContext CreateDbContext(string[] args)
        {
            // Build configuration to read the connection string
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<SchoolContext>();
            var connectionString = configuration.GetConnectionString("SchoolDBConnectionString");
            builder.UseSqlServer(connectionString);

            return new SchoolContext(builder.Options);
        }
    }
}