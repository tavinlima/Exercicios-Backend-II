using System;
using System.Threading;

namespace Atividade01.Classes
{
    public abstract class Elevador
    {
        protected int andarAtual;
        protected int andar;
        protected int totalAndares;
        protected int capacidade;
        public int qntdPessoas;

        public void Inicializar()
        {
            Console.WriteLine("Qual a capacidade do elevador? ");
            capacidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos andares tem o elevador? ");
            totalAndares = int.Parse(Console.ReadLine());

            andarAtual = 0;

            Console.WriteLine("Elevador iniciando...");
            Thread.Sleep(2000);

            Console.WriteLine($"\nCapacidade do elevador: {capacidade} Número de andares: {totalAndares}\n");
        }

        public void Entrar()
        {
            Console.WriteLine($@"
Bem vindo!
Entrando...             
                ");
            Thread.Sleep(2000);

            Console.WriteLine("Quantas pessoas estão no elevador? ");
            qntdPessoas = int.Parse(Console.ReadLine());

            do
            {
                if (qntdPessoas <= capacidade)
                {
                    Console.WriteLine($"Há {qntdPessoas} pessoas no elevador");
                }
                else
                {
                    Console.WriteLine("Capacidade máxima atingida.");
                    Sair();
                }
            } while (qntdPessoas > capacidade);
        }

        public void Sair()
        {
            if (qntdPessoas >= 1)
            {
                Console.WriteLine("Quantas pessoas desejam sair? ");
                int qntdSair = int.Parse(Console.ReadLine());

                qntdPessoas = qntdPessoas - qntdSair;
                Console.WriteLine("Adeus :)");
                Thread.Sleep(2000);
            }
            else
            {
                Console.WriteLine("Não tem ninguém para sair...");
            }
        }

        public void Subir()
        {
            do
            {
                Console.WriteLine("Para onde deseja subir? ");
                andar = int.Parse(Console.ReadLine());
                if (andar < totalAndares)
                {

                    Console.WriteLine("Subindo... ");
                    Thread.Sleep(2000);

                    Console.WriteLine($"Você chegou ao {andar}º andar!");
                    andarAtual = andar;
                }
                else if (andar > totalAndares)
                {
                    Console.WriteLine("Operação impossível");
                }
                else if (andarAtual == andar)
                {
                    Console.WriteLine($"Você já está no {andar}º andar!");
                }

            } while (andarAtual == totalAndares);
            andarAtual = andar;
        }

        public void Descer()
        {
            Console.WriteLine("Para onde deseja descer? ");
            andar = int.Parse(Console.ReadLine());
            do
            {
                if (andar > 0)
                {

                    Console.WriteLine("Descendo...");
                    Thread.Sleep(2000);

                    Console.WriteLine($"Você chegou ao {andar}º andar!");
                    andarAtual = andar;
                }
                else if (andar < 0)
                {
                    Console.WriteLine("Operação impossível");
                }
                else if (andarAtual == andar)
                {
                    Console.WriteLine($"Você já está no {andar}º andar!");
                }

            } while (andarAtual == 0);
        }
    }
}