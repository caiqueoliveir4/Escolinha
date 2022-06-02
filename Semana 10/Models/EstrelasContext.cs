using Microsoft.EntityFrameworkCore;

namespace WebApi01.Models
{
    public class EstrelasContext : DbContext
    {
        public EstrelasContext(DbContextOptions<EstrelasContext> options) : base(options)
        {            
        }

        public DbSet<Estrela> Estrelas { get; set; }
        public DbSet<Sistema> Sistemas { get; set; }

    }

}