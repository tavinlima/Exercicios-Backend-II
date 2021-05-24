using System;
using ExemploPOOPilares.classes;

namespace ExemploPOOPilares
{
    class Program
    {
        static void Main(string[] args)
        {
            bool opcaoValida = false;

            do
            {
                Console.WriteLine($@"
            Escolha um método de pagamento:
            
                    b - Boleto
                    c - Crédito
                    d - Débito
             
                x - Cancelar pagamento
             ");
                string opcao = Console.ReadLine().ToLower();

                switch (opcao)
                {
                    case "b":
                        Boletocs b = new Boletocs();
                        b.Registrar();
                        opcaoValida = true;
                        break;
                    case "c":
                        Credito c = new Credito();
                        Console.WriteLine(c.SalvarCartao());
                        c.Pagar();
                        opcaoValida = true;
                        break;
                    case "d":
                        Debito d = new Debito();
                        Console.WriteLine(d.SalvarCartao());
                        d.Pagar();
                        opcaoValida = true;
                        break;
                    case "x":
                        Pagamento p = new Pagamento();
                        Console.WriteLine(p.Cancelar());
                        opcaoValida = true;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("OPÇÃO INVÁLIDA!!!");
                        Console.ResetColor();
                        opcaoValida = false;
                        break;
                }


            } while (!opcaoValida);
        }
    }
}
