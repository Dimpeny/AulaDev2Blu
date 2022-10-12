using AgendaCadastro.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCadastro.Models
{
    public class Compromisso
    {
        public Int32 Id { get; set; }
        public String Descricao { get; set; }
        public DateTime DataCompromisso { get; set; }
        public DiaSemana DiaSemana { get; set; }
        public Contato Contato { get; set; }
        public Status Status { get; set; }
        public Compromisso()
        {
            Status = Status.A;
        }

        public Compromisso(int id, string descricao, DateTime dataCompromisso, DiaSemana diaSemana, Contato contato, Status status)
        {
            Id = id;
            Descricao = descricao;
            DataCompromisso = dataCompromisso;
            DiaSemana = diaSemana;
            Contato = contato;
            Status = status;
        }
    }
}
