using Microsoft.EntityFrameworkCore;
namespace AppEscolaDeMusica.DataContexts
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
