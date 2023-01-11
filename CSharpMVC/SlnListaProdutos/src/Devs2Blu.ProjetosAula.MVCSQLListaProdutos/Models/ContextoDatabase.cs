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
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId);

            modelBuilder.Entity<Categoria>()
                .HasData(
                new { Id = 1, Nome = "Alimentos não pereciveis" },
                new { Id = 2, Nome = "Laticineos" },
                new { Id = 3, Nome = "Limpeza" },
                new { Id = 4, Nome = "Bebidas não alcolicas" }
                );

            modelBuilder.Entity<Produto>()
                 .HasData(
                     new { Id = 1, Nome = "Arroz Tio Urbano", Preco = 10.00, Quantidade = 5, CategoriaId = 1 },
                     new { Id = 2, Nome = "Feijão Tio Urbano", Preco = 10.00, Quantidade = 5, CategoriaId = 1 },
                     new { Id = 3, Nome = "Queijo", Preco = 20.00, Quantidade = 5, CategoriaId = 2 },
                     new { Id = 4, Nome = "Iogurte", Preco = 20.00, Quantidade = 5, CategoriaId = 2 },
                     new { Id = 5, Nome = "Sabão Líquido", Preco = 30.00, Quantidade = 5, CategoriaId = 3 },
                     new { Id = 6, Nome = "Multiuso", Preco = 30.00, Quantidade = 5, CategoriaId = 3 },
                     new { Id = 7, Nome = "Suco de Laranja 1L", Preco = 40.00, Quantidade = 5, CategoriaId = 4 },
                     new { Id = 8, Nome = "Coca-Cola 2L", Preco = 40.00, Quantidade = 5, CategoriaId = 4 }
                 );
            base.OnModelCreating(modelBuilder);
        }

        #region DBSets
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        #endregion
    }
}
