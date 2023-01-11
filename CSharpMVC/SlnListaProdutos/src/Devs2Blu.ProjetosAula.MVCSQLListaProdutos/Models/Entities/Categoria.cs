﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Devs2Blu.ProjetosAula.MVCSQLListaProdutos.Models.Entities
{   [Table("categoria")]
    public class Categoria
    {
        [Column("id")]
        [Display(Name = "Código")]
        public int Id { get; set; }
        [Column("nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        public ICollection<Produto>? Produtos {get;set;}
    }
}
