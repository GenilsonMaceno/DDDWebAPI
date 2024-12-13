using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DDDWebAPI.Infrastructure.Data
{
    internal class SQLContextFactory : IDesignTimeDbContextFactory<SQLContext>
    {
        public SQLContext CreateDbContext(string[] args)
        {
            var pathJson = Directory.GetParent("C:\\Projetos\\DDDApi\\src\\DDDWebAPI\\DDDWebAPI\\").ToString();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(pathJson)
                .AddJsonFile("appsettings.Development.json")
                .Build();

            var connectionString = configuration.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<SQLContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new SQLContext(optionsBuilder.Options);
        }
    }
}
