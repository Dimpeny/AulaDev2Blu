using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Aula5
{
    internal class Program
    {
        const string A21 = "A21";
        const string A22 = "A22";
        const string A23 = "A23";
        const string A24 = "A24";
        const string A35 = "A35";
        const string Z16 = "Z16";
        static void Main(string[] args)
        {
            string rotina;
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Bem vindo(a) ao programa da aula 5 (switch case)");
            Console.WriteLine("| ");
            do
            {
                Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("| Selecione uma rotina para executar");
                Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("| EXEMPLOS");
                Console.WriteLine("| EXP1 - Exemplo 1, Códigos de produtos");
                Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("| EXERCICIOS");
                Console.WriteLine("| EXC1 - Exercicio 1, Códigos de frutas");
                Console.WriteLine("| EXC2 - Exercicio 2, Compra de carro");
                Console.WriteLine("| EXC2 - Exercicio 5, Jogo do 21");
                Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                Console.WriteLine("| SAIR - Terminar a execução");
                Console.Write("| Código de rotina: ");
                rotina = Console.ReadLine();

                Console.Clear();

                switch (rotina.ToUpper())
                {
                    case "EXP1":
                        Exemplo1();
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
                    case "EXC5":
                        Exercicio5();
                        MostrarMensagemRetorno();
                        break;
                    case "SAIR":
                        Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("| Obrigado por usar o meu programa!");
                        Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        break;
                    default:
                        Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        Console.WriteLine("| Código de rotina invalido!");
                        Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                        MostrarMensagemRetorno();
                        break;
                }

            } while (rotina.ToUpper() != "SAIR");

        }

        static void MostrarMensagemRetorno()
        {
            Console.WriteLine("| ");
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Retornando ao menu principal");
            Console.WriteLine("| Precione enter para continuar");
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.ReadLine();
            Console.Clear();
        }

        static void Exemplo1()
            {
            /*
            - "A23" : Materiais
            - "A35": Produtos Perecíveis
            - "Z16": Produtos Químicos
             */

            string codigo;

            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Exemplo 1");
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Escolha um código para ver a descrição");
            Console.WriteLine("| A21");
            Console.WriteLine("| A22");
            Console.WriteLine("| A23");
            Console.WriteLine("| A24");
            Console.WriteLine("| A35");
            Console.WriteLine("| Z16");
            Console.WriteLine("| ");
            Console.Write("| Código: ");

            codigo = Console.ReadLine();

            switch (codigo.ToUpper())
            {
                case A21:
                case A22:
                case A23:
                case A24:
                    Console.WriteLine("| Materiais");
                    break;
                case A35:
                    Console.WriteLine("| Produtos Perecíveis");
                    break;
                case Z16:
                    Console.WriteLine("| Produtos Químicos");
                    break;
                default:
                    Console.WriteLine("| Código invalido");
                    break;
            }
        }

        static void Exercicio1()
        {

            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Exercicio 1");
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            string fruta;
            Console.WriteLine("| Selecione a fruta que quer comprar");
            Console.WriteLine("| Maçã");
            Console.WriteLine("| Kiwi");
            Console.WriteLine("| Melancia");
            Console.WriteLine("| ");
            Console.Write("| Fruta: ");
            fruta = Console.ReadLine();

            switch (fruta.ToLower())
            {
                case "maçã":
                    Console.WriteLine("| Não vendemos essa fruta aqui");
                    break;

                case "kiwi":
                    Console.WriteLine("| Estamos com escassez de kiwi");
                    break;
                case "melancia":
                    Console.WriteLine("| Aqui está, são 3 reais o quilo");
                    break;
            }
        }

        static void Exercicio2()
        {
            /*
            2 - Um homem decidiu ir à uma revenda comprar um carro . Ele deseja comprar um carro hatch , e a
            revenda possui , além de carros hatch , sedans , motocicletas e caminhonetes . Utilizando uma
            estrutura switch / case , caso o comprador queira o hatch , retorne : " Compra efetuada com
            sucesso " . Nas outras opções , retorne : " Tem certeza que não prefere este modelo ? " . Caso seja
            especificado um modelo que não está disponível , retorne no console : " Não trabalhamos com este
            tipo de automóvel aqui "
             */
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Exercicio 2");
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            string veiculoSelecionado;
            Console.WriteLine("| Selecione o veiculo que quer comprar");
            Console.WriteLine("| 001- Hatch");
            Console.WriteLine("| 002- Sedan");
            Console.WriteLine("| 003- Motocicleta");
            Console.WriteLine("| 004- Caminhonete");
            Console.Write("| Fruta: ");
            veiculoSelecionado = Console.ReadLine();

            switch (veiculoSelecionado)
            {
                case "001":
                    Console.WriteLine("| Compra efetuada com sucesso");
                    break;
                case "002":
                case "003":
                case "004":
                    Console.WriteLine("| Tem certeza que não prefere este modelo ?");
                    break;
                default:
                    Console.WriteLine("| Não trabalhamos com este tipo de automóvel aqui");
                    break;
            }
        }

        static void Exercicio3()
        {

        }

        static void Exercicio5()
        {
            Random aleatorio = new Random();
            int numeroJogador,pontuacaoJogador, numeroAleatorio, numeroCpu,pontuacaoCpu;
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.WriteLine("| Exercicio 5");
            Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
            Console.Write("| Digite um numero de 1 a 20\n| ");
            string numeroJogadorStr = Console.ReadLine();
            bool valido = Int32.TryParse(numeroJogadorStr, out numeroJogador);

            if (valido) {
                if (numeroJogador < 1)
                {
                    Console.WriteLine("| Seu número não pode ser menor que 1");
                }
                else if (numeroJogador > 20)
                {
                    Console.WriteLine("| Seu número não pode ser maior que 20");
                }
                else
                {
                    numeroAleatorio = aleatorio.Next(1, 20);
                    numeroCpu = aleatorio.Next(1, 20);

                    pontuacaoJogador = numeroJogador + numeroAleatorio;
                    pontuacaoCpu = numeroCpu + numeroAleatorio;

                    switch (pontuacaoJogador)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            pontuacaoJogador = 1;
                            break;

                        case 7:
                            pontuacaoJogador = 10;
                            break;

                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                            pontuacaoJogador = 5;
                            break;

                        case 14:
                            pontuacaoJogador = 20;
                            break;

                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                            pontuacaoJogador = 6;
                            break;

                        case 21:
                            pontuacaoJogador = 30;
                            break;

                        default:
                            pontuacaoJogador = 0;
                            break;
                    }

                    switch (pontuacaoCpu)
                    {
                        case 1:
                        case 2:
                        case 3:
                        case 4:
                        case 5:
                        case 6:
                            pontuacaoCpu = 1;
                            break;

                        case 7:
                            pontuacaoCpu = 10;
                            break;

                        case 8:
                        case 9:
                        case 10:
                        case 11:
                        case 12:
                        case 13:
                            pontuacaoCpu = 5;
                            break;

                        case 14:
                            pontuacaoCpu = 20;
                            break;

                        case 15:
                        case 16:
                        case 17:
                        case 18:
                        case 19:
                        case 20:
                            pontuacaoCpu = 6;
                            break;

                        case 21:
                            pontuacaoCpu = 30;
                            break;

                        default:
                            pontuacaoCpu = 0;
                            break;
                    }

                    Console.WriteLine("|=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=");
                    Console.WriteLine($"| O número aleatório foi: {numeroAleatorio}");
                    Console.WriteLine($"| O número do Jogador foi {numeroJogador}");
                    Console.WriteLine($"| A pontuação do jogador ficou: {pontuacaoJogador}");
                    Console.WriteLine($"| O número da CPU foi {numeroCpu}");
                    Console.WriteLine($"| A pontuação da CPU ficou: {pontuacaoCpu}");
                }
            }
            else
            {

                Console.WriteLine("| Esta rotina só aceita numeros inteiros.");
            }
            
            
        }
    }
}
