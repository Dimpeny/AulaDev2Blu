using AgendaCadastro.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCadastro.Models
{
    public class Contato
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public String NumeroTelefonico { get; set; }
        public String Cep { get; set; }
        public Int32 Numero { get; set; }
        public String Rua { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public Estado Estado { get; set; }
        public Status Status { get; set; }
    }
}
