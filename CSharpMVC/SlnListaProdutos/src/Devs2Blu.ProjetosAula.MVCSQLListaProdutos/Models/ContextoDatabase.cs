using Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Models
{
    public class ContextoDatabase : DbContext
    {
        //Add-Migration Inicial-tabelas -Context ContextoDatabase
        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos);
            base.OnModelCreating(modelBuilder);
        }

        #region DBSets
        public DbSet<Categoria> Categoria {get;set;}
        public DbSet<Produto> produto { get; set; }
        #endregion
    }
}
