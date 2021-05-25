using System;

namespace ExemploPOOPilares.classes
{
    public abstract class Cartaocs : Pagamento
    {
        public string bandeira;
        public string numero;
        public string titular;
        public string cvv;

        public string SalvarCartao(){
            Console.WriteLine("Digite a bandeira do cartão: ");
            bandeira = Console.ReadLine();

            Console.WriteLine("Digite o numero do cartão: ");
            numero= Console.ReadLine();

            Console.WriteLine("Digite o titular do cartão: ");
            titular = Console.ReadLine();

            Console.WriteLine("Digite o cvv do cartão: ");
            cvv = Console.ReadLine();

            return $"Cartão de número {numero} salvo com sucesso!";
        }
    }
}