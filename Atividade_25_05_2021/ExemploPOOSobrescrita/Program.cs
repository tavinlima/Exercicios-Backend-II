using System;
using ExemploPOOSobrescrita.Classes;

namespace ExemploPOOSobrescrita
{
    class Program
    {
        static void Main(string[] args)
        {
            MegaMan m = new MegaMan();
            Zero z = new Zero();

            Console.WriteLine("MegaMan: ");
            Console.WriteLine(m.Pular());
            Console.WriteLine(m.Correr());

            Console.WriteLine("Zero: ");
            Console.WriteLine(z.Pular());
            Console.WriteLine(z.Correr());
        }
    }
}
