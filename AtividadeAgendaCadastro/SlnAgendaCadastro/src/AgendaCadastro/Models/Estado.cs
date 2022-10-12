using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaCadastro.Models
{
    public class Estado
    {
        public Int32 Id { get; set; }
        public string Uf { get; set; }
        public string Descricao { get; set; }

        public Estado()
        {

        }

        public Estado(int id, string uf, string descricao)
        {
            Id = id;
            Uf = uf;
            Descricao = descricao;
        }
    }
}
