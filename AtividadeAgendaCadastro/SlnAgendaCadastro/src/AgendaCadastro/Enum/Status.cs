using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCadastro.Enum
{
    public enum Status
    {
        [Description("Ativo")]
        A = 0,
        [Description("Inativo")]
        I = 1,
        [Description("Excluido")]
        E = 2,
        [Description("Remarcado")]
        R = 3
    }
}
