using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Classes
{
    public class Diretor : Pessoa
    {
        public double ProLabore { get; set; }

        public Diretor()
        {

        }
        public Diretor(string nome, string sobrenome, double proLabore)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.ProLabore = proLabore;
        }
    }
}
