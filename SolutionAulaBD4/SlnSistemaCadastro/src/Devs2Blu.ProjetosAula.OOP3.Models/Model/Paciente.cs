using Devs2Blu.ProjetosAula.sistemaCadastro.Models.Enum;
using Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.sistemaCadastro.Models.Model
{
    public class Paciente
    {
        public Int32 Id { get; set; }

        public Pessoa Pessoa { get; set; }
        public Convenio Convenio { get; set; }

        public Int32 NrProntuario { get; set; }

        public String PacienteRisco { get; set; }
        public FlStatus Status { get; set; }
        public Int32 FlObito { get; set; }
        public Paciente()
        {
            Pessoa = new Pessoa();
            Pessoa.TipoPessoa = TipoPessoa.PF;
            FlObito = 0;
            Status = FlStatus.A;
            Convenio = new Convenio();
        }

        public Paciente( Pessoa pessoa, Convenio convenio, int nrProntuario, string pacienteRisco)
        {
            Pessoa = pessoa;
            Convenio = convenio;
            NrProntuario = nrProntuario;
            PacienteRisco = pacienteRisco;
        }


    }
}
