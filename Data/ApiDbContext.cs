using Microsoft.EntityFrameworkCore;
using MonkTechWebAPI.Configurations.Seeding;
using MonkTechWebAPI.Models;

namespace MonkTechWebAPI.Data
{
    public class ApiDbContext : DbContext
    {
        public ApiDbContext(DbContextOptions options) : base(options)
        {
        }

        /*protected override void ConfigureConventions(ModelConfigurationBuilder builder)
        {
            builder.Properties<DateTime>().HaveColumnType("Date");
        }*/

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Agenda>().Property(p => p.Dia).HasColumnType("Date");

            ModuleSeeding.Seed(builder);
        }

        public DbSet<Salao> Saloes { get; set; } = null!;
        public DbSet<Endereco> Enderecos { get; set; } = null!;
        public DbSet<Agenda> Agendas { get; set; } = null!;
    }
}
