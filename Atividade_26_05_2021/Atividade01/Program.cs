using System;
using Atividade01.Classes;

namespace Atividade01
{
    class Program
    {
        static void Main(string[] args)
        {
            bool utilizarElevador = true;
            ElevadorSocial so = new ElevadorSocial();
            so.Inicializar();

            ElevadorServico se = new ElevadorServico();
            se.Inicializar();

            Console.WriteLine($@"
Qual elevador deseja utilizar?

        1 - Social

        2 - Serviço
            ");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                do
                {
                    Console.WriteLine($@"
O que deseja fazer? Selecione

 1 - Entrar
 2 - Subir 
 3 - Descer
 4 - Sair
 ");
                    string opcaoAndar = Console.ReadLine();

                    switch (opcaoAndar)
                    {
                        case "1":
                            so.Entrar();
                            break;
                        case "2":
                            so.Subir();
                            break;
                        case "3":
                            so.Descer();
                            break;
                        case "4":
                            so.Sair();
                            if (so.qntdPessoas == 0)
                            {
                                utilizarElevador = false;
                            }
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("OPERAÇÃO INVÁLIDA!!!");
                            Console.ResetColor();
                            break;
                    }

                } while (utilizarElevador);

            }
            else if (opcao == "2")
            {
                do
                {
                    Console.WriteLine($@"
O que deseja fazer? Selecione

 1 - Entrar
 2 - Subir 
 3 - Descer
 5 - Modificar número de caixas

 4 - Sair
 ");
                    string opcaoAndar = Console.ReadLine();

                    switch (opcaoAndar)
                    {
                        case "1":
                            se.Entrar();
                            break;
                        case "2":
                            se.Subir();
                            break;
                        case "3":
                            se.Descer();
                            break;
                        case "4":
                            se.numCaixas();
                            break;
                        case "5":
                            se.Sair();
                            if (so.qntdPessoas == 0)
                            {
                                utilizarElevador = false;
                            }
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("OPERAÇÃO INVÁLIDA!!!");
                            Console.ResetColor();
                            break;
                    }
                } while (utilizarElevador);
            }
        }
    }
}
