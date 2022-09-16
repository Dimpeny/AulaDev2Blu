using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Exercicio2();
        }
        static void Exercicio2()
        {
            int valor1, valor2, valor3, valor4;
            int menorValor = 2147483647;
            bool valores1e2iguais,valores3e4iguais;

            Console.WriteLine("| Programa que acha o menor de 4 valores.");

            Console.Write("| Informe o primeiro valor \n| ");
            string valor1Str = Console.ReadLine();
            Int32.TryParse(valor1Str, out valor1);

            Console.Write("| Informe o segundo valor \n| ");
            string valor2Str = Console.ReadLine();
            Int32.TryParse(valor2Str, out valor2);

            Console.Write("| Informe o terceiro valor \n| ");
            string valor3Str = Console.ReadLine();
            Int32.TryParse(valor3Str, out valor3);

            Console.Write("| Informe o quarto valor \n| ");
            string valor4Str = Console.ReadLine();
            Int32.TryParse(valor4Str, out valor4);
            if(valor1 == valor2 && valor3 == valor4 && valor1 == valor4)
            {
                Console.WriteLine("Todos os valores são iguais!");
            } else 
            {
                if (valor1 < menorValor)
                {
                    menorValor = valor1;
                }
                if(valor2 < menorValor)
                {
                    menorValor = valor2;
                }
                if(valor3 < menorValor)
                {
                    menorValor = valor3;
                }
                if(valor4 < menorValor)
                {
                    menorValor=valor4;
                }

                Console.WriteLine($"| O menor valor é {menorValor}");
            }
        }

        static void Exercicio1()
        {
            int primeiroValor, segundoValor;
            Console.Write("| informe o primeiro número inteiro:\n| ");
            string primeiroValorStr = Console.ReadLine();
            Int32.TryParse(primeiroValorStr, out primeiroValor);
            Console.Write("| informe o segundo número inteiro:\n| ");
            string segundoValorStr = Console.ReadLine();
            Int32.TryParse(segundoValorStr, out segundoValor);

            if (primeiroValor > segundoValor)
            {
                Console.WriteLine($"| O primeiro número é o maior ({primeiroValor})");
            }
            else if (segundoValor > primeiroValor)
            {
                Console.WriteLine($"| O segundo número é o maior ({segundoValor})");
            }
            else
            {
                Console.WriteLine("| Os dois números informados são iguais.");
            }
        }

        static void Exemplo1()
        {
            string nomeCandidato, textoSaida;
            int idade, nota;

            Console.WriteLine("| Bem vindo ao programa Syschool |\n|\n|");

            Console.Write("| Informe o nome do candidato:\n| ");
            nomeCandidato = Console.ReadLine();

            Console.Write("| Informe a idade do candidato:\n| ");
            string idadeStr = Console.ReadLine();
            if (idadeStr.Equals(""))
            {
                Console.WriteLine("| A idade deve ser um numero |");
                return;
            }
            else
            {
                idade = Int32.Parse(idadeStr);
            }

            Console.Write("| Informe a nota do candidato:\n| ");
            string notaStr = Console.ReadLine();
            if (notaStr.Equals(""))
            {
                Console.WriteLine("| A nota deve ser um numero |");
                return;
            }
            else
            {
                nota = Int32.Parse(notaStr);
            }

            textoSaida = $"| Candidato: {nomeCandidato} |\n";
            textoSaida += $"| Idade: {idade}";

            if (idade < 18)
            {
                textoSaida += " (Menor de Idade) |\n";
            }
            else
            {
                textoSaida += " (Maior de Idade) |\n";
            }
            textoSaida += $"| Nota final: {nota} |\n";
            if (nota > 5)
            {
                textoSaida += "| Aprovado(a)! | ";
            }
            else
            {
                textoSaida += "| Reprovado(a)... | ";
            }

            Console.WriteLine(textoSaida);
        }
    }
}
