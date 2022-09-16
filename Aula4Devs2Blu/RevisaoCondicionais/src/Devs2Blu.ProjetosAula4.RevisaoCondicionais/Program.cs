using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula4.RevisaoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            Console.WriteLine("Seja bem vindo ao programa locão!!");
            do
            {
                Console.WriteLine("| Escolha o programa desejado:");
                Console.WriteLine("| 1- Exemplo 1");
                Console.WriteLine("| 2- Exemplo 2");
                Console.WriteLine("| 3- Exemplo 3");
                Console.WriteLine("| 6-Questão 6");
                Console.WriteLine("|_-_-_-_-_-_-_-");
                Console.WriteLine("| 0- Sair");
                string opcaoStr = Console.ReadLine();
                Int32.TryParse(opcaoStr, out opcao);
                Console.Clear();

                if (opcao == 0)
                {
                    Console.WriteLine("Muito grato, volte sempre!");
                }
                else if (opcao == 1)
                {
                    Exercicio1();
                }
                else if (opcao == 2)
                {
                    Exercicio2();
                }
                else if (opcao == 3)
                {
                    Exercicio3();
                }else if(opcao == 6)
                {
                    Questao6();
                }

            } while (opcao != 0);
        }

        static void Exercicio1()
        {
            int numeroInformado;

            Console.WriteLine("| Exercicio 1 |");
            Console.WriteLine("| Programa que verifica se um numero é par ou impar. |");
            Console.Write("| Digite um numero inteiro:\n| ");

            string numeroInformadoStr = Console.ReadLine();
            Int32.TryParse(numeroInformadoStr, out numeroInformado);

            if( (numeroInformado - numeroInformado / 2 * 2) != 0)
            {
                Console.WriteLine($"| O numero {numeroInformado} é impar");
            }
            else
            {
                Console.WriteLine($"| O numero {numeroInformado} não é impar");
            }
        }

        static void Exercicio2()
        {
            string codigoProduto;

            Console.WriteLine("| Exercicio 2 |");
            Console.WriteLine("| Programa que retorna o nome de um produto a partir de um código. |");
            Console.Write("| Digite um numero inteiro:\n| ");

            codigoProduto = Console.ReadLine();

            if(codigoProduto == "001")
            {
                Console.WriteLine("| Arroz.");
            }else if (codigoProduto == "002")
            {
                Console.WriteLine("| Feijão.");
            }
            else if (codigoProduto == "003")
            {
                Console.WriteLine("| Farinha.");
            }
            else
            {
                Console.WriteLine("| Produtos diversos");
            }
        }

        static void Exercicio3()
        {
            int anoNascimento, anoAtual;

            Console.WriteLine("| Exercicio 2 |");
            Console.WriteLine("| Programa que retorna se o usuario tem idade para votar. |");
            Console.Write("| Digite o ano atual:\n| ");

            string anoAtualStr = Console.ReadLine();
            Int32.TryParse(anoAtualStr, out anoAtual);

            Console.Write("| Digite o seu ano de nascimento:\n| ");

            string anoNascimentoStr = Console.ReadLine();
            Int32.TryParse(anoNascimentoStr, out anoNascimento);

            if(anoAtual-anoNascimento < 16)
            {
                Console.WriteLine("| Você não tem idade para votar ainda");
            }
            else
            {
                Console.WriteLine("| Você já tem idade para votar!");
            }

        }

        static void Questao6()
        {
            const string SENHA = "1234";
            string senhaDigitada;

            Console.WriteLine("| Exercicio 2 |");
            Console.WriteLine("| Programa que valida se digitou a senha correta. |");
            Console.Write("| Digite a senha:\n| ");

            senhaDigitada = Console.ReadLine();

            if(senhaDigitada.Equals(SENHA))
            {
                Console.WriteLine("| ACESSO PERMITIDO ");
            }
            else
            {
                Console.WriteLine("| ACESSO NEGADO");
            }
        }
    }
}
