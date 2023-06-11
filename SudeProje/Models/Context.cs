using Microsoft.EntityFrameworkCore;
using SudeProje.Models;

namespace SudeProje.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-C0CN9AM; database=SudeProjeDb; integrated security=true; TrustServerCertificate=True");
        }

        public DbSet<Kullanici> Kullanicis { get; set; }
        public DbSet<Ders> Derss { get; set; }
        public DbSet<Uygulamali> Uygulamalis { get; set; }
        public DbSet<Sertfika> Sertfikas { get; set; }
        public DbSet<Admin> Admins { get; set; }

    }
}
