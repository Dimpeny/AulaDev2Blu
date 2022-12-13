using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Models.Entities
{   [Table("produto")]
    public class Produto
    {
        [Column("id")]
        [Display(Name ="Código")]
        public int Id { get; set; }
        [Column("nome")]
        [Display(Name ="Nome")]
        public string Nome { get; set; }
        [Column("id_categoria")]
        [Display(Name ="Categoria")]
        public Categoria Categoria { get; set; }
        [Column("preco")]
        [Display(Name ="Preço")]
        public decimal Preco { get; set; }
        [Column("quantidade")]
        [Display(Name ="Quantidade")]
        public int Quantidade { get; set; }
    }
}
