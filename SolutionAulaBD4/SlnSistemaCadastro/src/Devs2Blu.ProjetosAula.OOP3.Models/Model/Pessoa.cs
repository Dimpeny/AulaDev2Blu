using Devs2Blu.ProjetosAula.sistemaCadastro.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.sistemaCadastro.Models.Model
{
    public class Pessoa
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String CGCCPF { get; set; }
        public TipoPessoa TipoPessoa { get; set; }

        public FlStatus Status { get; set; }

        public Pessoa()
        {
            Status = FlStatus.A;
        }
    }
}
