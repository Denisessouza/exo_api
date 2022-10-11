using ExoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace ExoApi.Contexts
{
    public class dbExoApiContext: DbContext //Herdando do Entity
    {
        public dbExoApiContext()
        {

        }

        public dbExoApiContext(DbContextOptions<dbExoApiContext> options) :base(options) //SuperClasse é a DBContext
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source = DENISE-SOUZA\\SQLEXPRESS; initial catalog = db_Exo;"); //Aqui poderia ter colocado user e password do SQL
            }
        }

        public DbSet<Projeto> Projetos { get; set; }
    }
}
