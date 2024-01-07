using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace SonDaoBlog.Data
{
    public class SonDaoBlogContextFactory : IDesignTimeDbContextFactory<SonDaoBlogContext>
    {
        public SonDaoBlogContext CreateDbContext(string[] args)
        {
            var configuration = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();
            var builder = new DbContextOptionsBuilder<SonDaoBlogContext>();
            builder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            return new SonDaoBlogContext(builder.Options);
        }
    }
}
