using System;
using Atividade03.Classes;

namespace Atividade03
{
    class Program
    {
        static void Main(string[] args)
        {
            int qntdAcucar;
            bool adcAcucar = true;
            bool novoCafe = true;
            MaquinaCafe m = new MaquinaCafe();
            m.acucarDisponivel = 500;

            do
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($@"
Olá! Bem vindo a sua mais nova Super CafeteiraTabajaras Plus++ :)

                Para fazer seu café:

                Com açúcar digite 1. 
                Sem açúcar digite 2.

                Para FECHAR: digite 0.
            ");
                Console.ResetColor();

                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        if (m.acucarDisponivel <= 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nNão há mais açúcar disponível :(\n");
                            Console.ResetColor();

                            Console.WriteLine(m.FazerCafe());
                        }
                        else
                        {
                            do
                            {
                                Console.WriteLine("Olá! Deseja informar a quantidade de açúcar? S/N (Padrão = 10g)");
                                string infQntd = Console.ReadLine().ToUpper();
                                if (infQntd == "S")
                                {
                                    Console.WriteLine("Quanto de açúcar deseja adicionar? (em g)");
                                    qntdAcucar = int.Parse(Console.ReadLine());
                                    m.FazerCafe(qntdAcucar);
                                    adcAcucar = true;
                                }
                                else if (infQntd == "N")
                                {
                                    qntdAcucar = 10;
                                    m.FazerCafe(qntdAcucar);
                                    adcAcucar = true;
                                }
                                else
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\nERRO!!! Digite novamente.\n");
                                    Console.ResetColor();

                                    adcAcucar = false;
                                }
                            } while (!adcAcucar);
                        }
                        break;

                    case "2":
                        Console.WriteLine(m.FazerCafe());
                        break;

                    case "0":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("\nOPERAÇÃO FECHADA!!! Obrigado por usar a mais nova Super CafeteiraTabajaras Plus++ :)\n");
                        Console.ResetColor();
                        novoCafe = false;
                        break;
                    default:
                        break;
                }
            } while (novoCafe);
        }
    }
}
