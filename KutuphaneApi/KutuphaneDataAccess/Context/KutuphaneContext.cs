using KutuphaneDataAccess.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace KutuphaneDataAccess.Context
{
    public class KutuphaneContext:DbContext
    {


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(connectionString: @"server = localhost; user = root; password = welat.123; database = kutuphaneDB;");
        }

        public DbSet<Yazar> Yazars { get; set; }
        public DbSet<Uye> Uyes { get; set; }
        public DbSet<Kitap> kitaps { get; set; }

    }
}
