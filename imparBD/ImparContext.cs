using imparviagem.model;
using Microsoft.EntityFrameworkCore;

namespace imparviagem.imparBD

{
    public class ImparContext : DbContext
    {
        public ImparContext(DbContextOptions<ImparContext> options) : base(options)
        {




        }
        public DbSet<model.Cliente> Cliente { get; set; }
        public DbSet<model.Hotel> Hotel { get; set; }
        public DbSet<model.Viagem> Viagem { get; set; }
    }
}
