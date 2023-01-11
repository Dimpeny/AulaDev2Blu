using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.ListaJogos.Models.Entities
{
    [Table("Jogo")]
    public class Jogo
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Jogo")]
        public int Nome { get; set; }

        [Column("CategoriaId")]
        [Display(Name = "Categoria")]
        public int CategoriaId { get; set; }

        [Column("Descricao")]
        [Display(Name = "Descrição")]
        public int Descricao { get; set; }

        public virtual Categoria? Categoria { get; set; }
    }
}