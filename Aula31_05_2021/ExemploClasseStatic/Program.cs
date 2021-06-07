using System;
using ExemploClasseStatic.Classes;

namespace ExemploClasseStatic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("R$: " + Conversor.DolarToReal(52));
            Console.WriteLine("U$: " + Conversor.RealToDolar(52));
        }
    }
}
