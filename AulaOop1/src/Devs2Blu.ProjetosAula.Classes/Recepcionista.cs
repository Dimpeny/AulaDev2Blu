using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public class Recepcionista : Pessoa
    {
        public int NumeroCracha { get; set; }

        public Recepcionista()
        {

        }

        public Recepcionista(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public Recepcionista(int numeroCracha,string endereco)
        {
            this.NumeroCracha = numeroCracha;
            this.Endereco = endereco;
        }

        public string AgendarConsulta()
        {
            return $"Consulta Agendada!";
        }

    }
}
