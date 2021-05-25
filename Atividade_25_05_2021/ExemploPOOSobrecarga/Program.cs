using System;
using ExemploPOOSobrecarga.Classes;

namespace ExemploPOOSobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f = new Funcionario();

            for (var i = 0; i < f.lista.Length; i++)
            {
                Console.WriteLine("Digite um nome para a lista: ");
                f.lista[i] = Console.ReadLine();
            }

            Console.WriteLine("\nMostrar nome sem argumentos");
            f.Mostrar();

            Console.WriteLine("\nDigite o indice que deseja saber (número)");
            int posicao = int.Parse(Console.ReadLine());
            f.Mostrar(posicao);

            Console.WriteLine("\nDigite o nome que deseja buscar");
            string buscarNome = Console.ReadLine();
            f.Mostrar(buscarNome);
        }
    }
}
