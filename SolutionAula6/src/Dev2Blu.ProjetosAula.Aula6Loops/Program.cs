using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dev2Blu.ProjetosAula.Aula6Loops
{
    internal class Program
    {
        /**
         * Menu principal
         * Usado para selecionar a rotina a ser rodada
         */
        static void Main(string[] args)
        {
            //Mensagem de boas vindas
            string rotina;
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Bem vindo(a) ao programa da aula 6 (do while)");
            Console.WriteLine("| ");

            //Loop de execução do menu
            do
            {
                //Mensagem do menu
                Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("| Selecione uma rotina para executar");
                Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("| EXEMPLOS");
                Console.WriteLine("| EXP1 - Exemplo 1");
                Console.WriteLine("| EXP2 - Exemplo 2");
                Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("| EXERCICIOS");
                Console.WriteLine("| EXC1 - Exercicio 1");
                Console.WriteLine("| EXC2 - Exercicio 2");
                Console.WriteLine("| EXC3 - Exercicio 3");
                Console.WriteLine("| EXC4 - Exercicio 4");
                Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("| SAIR - Terminar a execução");
                Console.Write("| Código de rotina: ");
                rotina = Console.ReadLine();

                //Limpeza da tela após leitura do código 
                Console.Clear();

                //Seleção de rotina
                switch (rotina.ToUpper())
                {
                    case "EXP1":
                        Exemplo1();
                        MostrarMensagemRetorno();
                        break;
                    case "EXP2":
                        Exemplo2();
                        MostrarMensagemRetorno();
                        break;
                    case "EXC1":
                        Exercicio1();
                        MostrarMensagemRetorno();
                        break;
                    case "EXC2":
                        Exercicio2();
                        MostrarMensagemRetorno();
                        break;
                    case "EXC3":
                        Exercicio3();
                        MostrarMensagemRetorno();
                        break;
                    case "EXC4":
                        Exercicio4();
                        MostrarMensagemRetorno();
                        break;
                        //Mensagem de saida
                    case "SAIR":
                        Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("| Obrigado por usar o meu programa!");
                        Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        break;
                        //Aviso de código invalido
                    default:
                        Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("| Código de rotina invalido!");
                        Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        MostrarMensagemRetorno();
                        break;
                }
                //Verificação de saida
            } while (rotina.ToUpper() != "SAIR");
        }

        /**
         Mensagem mostrada no final de cada rotina, limpa a tela antes de retornar ao menu
         */
        static void MostrarMensagemRetorno()
        {
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Pressione enter para voltar ao menu.");
            Console.Write("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadLine();
            Console.Clear();
        }

        /**
         
         */
        static void Exemplo1()
        {
            int controle = 1;
            while (controle > 0)
            {
                Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("| Informe o codigo 0 para sair");
                Console.Write("| ");
                Int32.TryParse(Console.ReadLine(), out controle);
                
            }
        }
        /**
         Exemplo 2 -
         */
        static void Exemplo2()
        {
            int controle = 0;
            
            do
            {
                Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("| Digite um dos códigos abaixo");
                Console.WriteLine("| 1- Exemplo1");
                Console.WriteLine("| 2- Exemplo2");
                Console.Write("| ");
                Int32.TryParse(Console.ReadLine(), out controle);
                Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");

                switch (controle)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    default:
                        break;
                }
            } while (controle > 0);
        }

        static void Exercicio1()
        {
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Exercicio 1");
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            int numero = 1;
            do
            {
                if (numero % 2 != 0)
                {
                    Console.WriteLine("| " + numero);
                }
                numero++;
            } while (numero < 100);
        }

        static void Exercicio2()
        {
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Exercicio 2");
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            int numero = 1;
            do
            {
                if (numero % 2 == 0)
                {
                    Console.WriteLine("| " + numero);
                }
                numero++;
            } while (numero < 100);

        }

        static void Exercicio3()
        {
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Exercicio 3");
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            int numeroCrescente = 1;
            int numeroInformado;
            Console.WriteLine("| Informe um número inteiro positivo");
            Int32.TryParse(Console.ReadLine(), out numeroInformado);
            if(numeroInformado < 1)
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Pares");
            do
            {
                if (numeroCrescente % 2 == 0)
                {
                    Console.WriteLine("| " + numeroCrescente);
                }
                numeroCrescente++;
            } while (numeroCrescente < numeroInformado);
            numeroCrescente = 1;
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Impares");
            do
            {
                if (numeroCrescente % 2 != 0)
                {
                    Console.WriteLine("| " + numeroCrescente);
                }
                numeroCrescente++;
            } while (numeroCrescente < numeroInformado);
        }

        static void Exercicio4()
        {
            int quantidadeAlunos, notaAtual, notaMedia, contador;
            notaMedia = 0;
            contador = 0;
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Exercicio 4");
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Digite o número de alunos na sala");
            Console.Write("| ");
            Int32.TryParse(Console.ReadLine(),out quantidadeAlunos);
            while(contador < quantidadeAlunos)
            {
                Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine($"| Digite a nota do aluno Nro. {contador+1}");
                Console.Write("| Nota: ");
                if (Int32.TryParse(Console.ReadLine(), out notaAtual))
                {
                   if(notaAtual < 11 && notaAtual > -1)
                    {
                        notaMedia += notaAtual;
                        contador++;
                    }else
                    {
                        Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("| A NOTA PRECISA SER UM NÚMERO DE 0 A 10!!");
                    }
                }
                else
                {
                    Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine("| A NOTA PRECISA SER UM NÚMERO INTEIRO!!");
                }
            }

            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine($"| A média da turma é: {notaMedia/quantidadeAlunos}");
        }
    }
}
