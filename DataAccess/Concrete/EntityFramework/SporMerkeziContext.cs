using Entites.Concrete.Sinif;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework;

public class SporMerkeziContext : DbContext
{
    public DbSet<EntitySinif> Siniflar { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=Zeynel;Database=SporBase;Trusted_Connection=true");
    }
}