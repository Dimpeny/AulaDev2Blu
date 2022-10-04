using Devs2Blu.ProjetosAula.sistemaCadastro.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.sistemaCadastro.Models.Model
{
    public class Recepcionista : Pessoa
    {
        public Int32 CodigoRecepcionista { get; set; }
        public String Setor { get; set; }

        private static Random Rd = new Random();
        public Recepcionista()
        {
            TipoPessoa = TipoPessoa.PF;
        }

        public Recepcionista(Int32 codigo, String nome, String cpf, string setor)
        {
            Id = codigo;
            Nome = nome;
            CGCCPF = cpf;
            TipoPessoa = TipoPessoa.PF;
            Setor = setor;

            
            CodigoRecepcionista = Int32.Parse($"{codigo}{Rd.Next(1000, 3000)}");
        }
    }
}
