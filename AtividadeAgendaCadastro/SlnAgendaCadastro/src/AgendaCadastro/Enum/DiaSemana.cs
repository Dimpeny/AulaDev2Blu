using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCadastro.Enum
{
    public enum DiaSemana
    {
        [Description("Segunda-Feira")]
        SEG = 0,
        [Description("Terça-Feira")]
        TER = 1,
        [Description("Quarta-Feira")]
        QUA = 2,
        [Description("Quinta-Feira")]
        QUI = 3,
        [Description("Sexta-Feira")]
        SEX = 4,
        [Description("Sabado")]
        SAB=5,
        [Description("Domingo")]
        DOM=6
    }
}
