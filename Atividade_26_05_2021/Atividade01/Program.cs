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
                    so.Entrar();
                    Console.WriteLine("O que deseja fazer? Selecione s - para subir ou d - para descer");
                    string opcaoAndar = Console.ReadLine().ToLower();

                    if (opcaoAndar == "s")
                    {
                        so.Subir();
                    }

                    else if (opcaoAndar == "d")
                    {
                        so.Descer();
                    }
                    so.Sair();
                    Console.WriteLine("Deseja utilizar o outro elevador? S/N");
                    string outroElevador = Console.ReadLine().ToUpper();
                    if (outroElevador == "S")
                    {
                        utilizarElevador = false;
                    }
                    else{
                        utilizarElevador = true;
                    }
                } while (utilizarElevador);

            }
            else if (opcao == "2")
            {
                do
                {
                    se.Entrar();
                    Console.WriteLine("Deseja alterar o número de caixas? S/N");
                    string altCaixas = Console.ReadLine().ToUpper();

                    if (altCaixas == "S")
                    {
                        se.numCaixas();
                    }
                    Console.WriteLine("O que deseja fazer? Selecione s - para subir ou d - para descer");
                    string opcaoAndar = Console.ReadLine().ToLower();

                    if (opcaoAndar == "s")
                    {
                        se.Subir();
                    }

                    else if (opcaoAndar == "d")
                    {
                        se.Descer();
                    }
                    se.Sair();
                    Console.WriteLine("Deseja utilizar o outro elevador? S/N");
                    string outroElevador = Console.ReadLine().ToUpper();
                    if (outroElevador == "S")
                    {
                        utilizarElevador = false;
                    }
                    else{
                        utilizarElevador = true;
                    }
                } while (utilizarElevador);
            }
        }
    }
}
