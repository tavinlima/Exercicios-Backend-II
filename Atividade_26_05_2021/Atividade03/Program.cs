using System;
using Atividade03.Classes;

namespace Atividade03
{
    class Program
    {
        static void Main(string[] args)
        {
            MaquinaCafe m = new MaquinaCafe();
            m.acucarDisponivel = 500;

            Console.WriteLine($@"
            Olá! Bem vindo a sua mais nova Super CafeteiraTabajaras Plus++ :)

            Para fazer seu café, digite 1.
            ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    if (m.acucarDisponivel > 0)
                    {
                        m.FazerCafe();
                    }
                    else
                    {
                        m.FazerCafe();
                    }
                    break;
                default:
                    break;
            }

        }
    }
}
