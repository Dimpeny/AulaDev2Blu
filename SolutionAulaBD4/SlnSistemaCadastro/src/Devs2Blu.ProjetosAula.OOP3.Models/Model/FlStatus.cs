using System.ComponentModel;

namespace Devs2Blu.ProjetosAula.sistemaCadastro.Models.Model
{
    public enum FlStatus
    {
        [Description("Excluido")]
        E = 0,
        [Description("Ativo")]
        A = 1,
        [Description("Inativo")]
        I = 2
    }
}