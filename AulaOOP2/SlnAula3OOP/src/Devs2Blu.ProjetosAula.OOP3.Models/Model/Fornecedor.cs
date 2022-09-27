using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models.Model
{
    public class Fornecedor : Pessoa
    {
        public Int32 CodigoFornecedor { get; set; }
        public String TipoFornecedor { get; set; }

        public Fornecedor()
        {
            TipoPessoa = Enum.TipoPessoa.PJ;
        }

        public Fornecedor(Int32 codigo, String nome, String cpf,String TipoFornecedor)
        {
            Codigo = codigo;
            Nome = nome;
            CGCCPF = cpf;
            TipoPessoa = Enum.TipoPessoa.PJ;
            TipoFornecedor = TipoFornecedor;
            Random rd = new Random();
            CodigoFornecedor = Int32.Parse($"{codigo}{rd.Next(3000, 3999)}");
        }
    }
}
