using Devs2Blu.ProjetosAula.ListaJogos.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.ListaJogos.Models
{
    public class ContextoDatabase : DbContext 
    {
        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base(options)
        { 
        
        }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        // Mapeamento de Relacionamento
        modelBuilder.Entity<Jogo>()
            .HasOne(p => p.Categoria)
            .WithMany(c => c.Jogos)
            .HasForeignKey(p => p.CategoriaId);

        // Seed
        modelBuilder.Entity<Categoria>()
            .HasData(
            new { Id = 1, Nome = "Horror" },
            new { Id = 2, Nome = "Sobrevivencia" },
            new { Id = 3, Nome = "Mobile" },
            new { Id = 4, Nome = "RTS" },
            new { Id = 5, Nome = "MMO RPG" },
            new { Id = 6, Nome = "FPS" },
            new { Id = 7, Nome = "Simulação" },
            new { Id = 8, Nome = "Ritmo" }
            );

        modelBuilder.Entity<Jogo>()
            .HasData(
            new { Id = 0, Nome = "NOME", Descricao = "", CategoriaId = 1 }
            );

        base.OnModelCreating(modelBuilder);
        }
        #region DbSets
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Jogo> Produto { get; set; }

        #endregion

    }

}
