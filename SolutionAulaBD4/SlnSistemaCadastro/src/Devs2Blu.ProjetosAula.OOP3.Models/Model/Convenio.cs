﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.SistemaCadastro.Models.Model
{
    public class Convenio
    {
        public Int32 Id { get; set; }
        public String Nome { get; set; }
        public FlConvStatus Status { get; set; }


        public Convenio()
        {
            Status = FlConvStatus.A;
        }

        public Convenio(string nome)
        {
            Status = FlConvStatus.A;
            Nome = nome;
        }

        public Convenio(int id, string nome, FlConvStatus status)
        {
            Id = id;
            Nome = nome;
            Status = status;
        }
    }
    public enum FlConvStatus
    {

        [Description("Inativo")]
        I = 0,
        [Description("Ativo")]
        A = 1
    }

}
