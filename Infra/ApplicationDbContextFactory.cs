using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Infra
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();

            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=TesteMRV;Trusted_Connection=True;");

            return new ApplicationDbContext(optionsBuilder.Options);
        }
    }
}