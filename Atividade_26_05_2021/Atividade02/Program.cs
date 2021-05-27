using System;
using Atividade02.Classes;

namespace Atividade02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cadastro = true;
            JogadorAtaque J1 = new JogadorAtaque();
            JogadorDefesa J2 = new JogadorDefesa();
            JogadorMeioCampo J3 = new JogadorMeioCampo();

            do
            {
                Console.WriteLine($@"
=======================================================
| Olá! Antes de começar, selecione a posição de jogo: |
=======================================================
|                1 - Ataque                           |
|                                                     |
|                2 - Defesa                           |
|                                                     |   
|                3 - Meio-Campo                       |
=======================================================
            ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        J1.MostrarDados();
                        J1.Aposentar();
                        cadastro = true;
                        break;

                    case "2":
                        J2.MostrarDados();
                        J2.Aposentar();
                        cadastro = true;
                        break;

                    case "3":
                        J3.MostrarDados();
                        J3.Aposentar();
                        cadastro = true;
                        break;

                    default:
                        Console.WriteLine("INVÁLIDO!!!");
                        cadastro = false;
                        break;
                }
            } while (!cadastro);
        }
    }
}
