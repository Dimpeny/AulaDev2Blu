using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.ListaJogos.Models.Entities
{
    [Table("Categoria")]
    public class Categoria
    {
        [Column("Id")]
        [Display(Name="Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name="Nome")]
        public string Nome { get; set; }

        public ICollection<Jogo>? Jogos { get; set; }
    }
}
