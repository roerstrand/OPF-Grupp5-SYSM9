using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Cyberquiz.DAL.Data
{
    // Denna klass behövs för att kunna köra migrations och update DB enbart i DAL
    public class AppDbContextFactory : IDesignTimeDbContextFactory<AppDbContext>
    {
        public AppDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=CyberquizDB;Trusted_Connection=True;MultipleActiveResultSets=true")
                .Options;

            return new AppDbContext(options);
        }
    }
}
