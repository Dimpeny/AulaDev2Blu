using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main
{
    internal class Program
    {
        public static Mocks Mock { get; set; }
        static void Main(string[] args)
        {
            Mock = new Mocks();
            ViewListaPacientes();
        }

        public static void ViewListaPacientes()
        {
            Console.Clear();

            foreach(var paciente in Mock.ListaPacientes)
            {
                Console.WriteLine("|=========================");
                Console.WriteLine($"|Paciente: {paciente.CodigoPaciente}");
                Console.WriteLine($"|Nome: {paciente.Nome}");
                Console.WriteLine($"|Cpf: {paciente.CGCCPF}");
                Console.WriteLine($"|Convenio: {paciente.Convenio}");
                Console.WriteLine("|");
            }
        }
    }
}
