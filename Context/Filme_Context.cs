using api_filmes_senai.Domains;
using Microsoft.EntityFrameworkCore;

namespace api_filmes_senai.Context
{
    public class Filme_Context : DbContext

        
    {
        public Filme_Context()
        {
        }
       
        public Filme_Context(DbContextOptions<Filme_Context>options) : base(options)
        { 
        }


        /// <summary>
        /// Define que as tabelas se transformarao em tabelas no BD
        /// </summary>
        public DbSet<Genero> Genero { get; set; }

        public DbSet<Filme> Filme { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server =DESKTOP-VINIDR3; Database = filmes; User Id = sa; Pwd = Senai@134; TrustServerCertificate=true;");
                //optionsBuilder.UseSqlServer("Server =DESKTOP-VINIDR3\\SQLEXPRESS; Database = filmes_julia; Integrated Security = true; TrustServerCertificate=true;");

            }


        }


    }
}
