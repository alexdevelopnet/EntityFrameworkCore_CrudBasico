using EntityFrameworkCore_CrudBasico.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityFrameworkCore_CrudBasico.Data
{
    public class ContextoCrudBasico : DbContext
    {
        public ContextoCrudBasico(DbContextOptions<ContextoCrudBasico>  options):base(options)
        {

        }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
