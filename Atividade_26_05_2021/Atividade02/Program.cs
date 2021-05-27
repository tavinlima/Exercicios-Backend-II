using System;
using Atividade02.Classes;

namespace Atividade02
{
    class Program
    {
        static void Main(string[] args)
        {
            JogadorAtaque J1 = new JogadorAtaque();
            JogadorDefesa J2 = new JogadorDefesa();
            JogadorMeioCampo J3 = new JogadorMeioCampo();
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
                    Console.WriteLine("Insira o nome de jogador: ");
                    J1.nome = Console.ReadLine();

                    Console.WriteLine("Insira o ano de nascimento de jogador:");
                    J1.anoNasc = int.Parse(Console.ReadLine());

                    Console.WriteLine("Insira a nacionalidade de jogador:");
                    J1.nacionalidade = Console.ReadLine();

                    Console.WriteLine("Insira a altura de jogador:");
                    J1.altura = float.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o peso de jogador:");
                    J1.peso = float.Parse(Console.ReadLine());

                    J1.MostrarDados();
                    J1.Aposentar();
                    break;
                case "2":
                    Console.WriteLine("Insira o nome de jogador: ");
                    J2.nome = Console.ReadLine();

                    Console.WriteLine("Insira o ano de nascimento de jogador:");
                    J2.anoNasc = int.Parse(Console.ReadLine());

                    Console.WriteLine("Insira a nacionalidade de jogador:");
                    J2.nacionalidade = Console.ReadLine();

                    Console.WriteLine("Insira a altura de jogador:");
                    J2.altura = float.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o peso de jogador:");
                    J2.peso = float.Parse(Console.ReadLine());

                    J2.MostrarDados();
                    J2.Aposentar();
                    break;
                case "3":
                    Console.WriteLine("Insira o nome de jogador: ");
                    J3.nome = Console.ReadLine();

                    Console.WriteLine("Insira o ano de nascimento de jogador:");
                    J3.anoNasc = int.Parse(Console.ReadLine());

                    Console.WriteLine("Insira a nacionalidade de jogador:");
                    J3.nacionalidade = Console.ReadLine();

                    Console.WriteLine("Insira a altura de jogador:");
                    J3.altura = float.Parse(Console.ReadLine());

                    Console.WriteLine("Insira o peso de jogador:");
                    J3.peso = float.Parse(Console.ReadLine());

                    J3.MostrarDados();
                    J3.Aposentar();
                    break;
                default:
                Console.WriteLine("INVÁLIDO!!!");
                    break;
            }



        }
    }
}
