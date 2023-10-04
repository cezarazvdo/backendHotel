using Hotel.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Hotel.Infra.Context
{
    public class AppAgendamentoContext : DbContext
    {
        public AppAgendamentoContext(DbContextOptions<AppAgendamentoContext> options) : base(options) { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Address> Address { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppAgendamentoContext).Assembly);
            base.OnModelCreating(modelBuilder);
        }


    }
}
