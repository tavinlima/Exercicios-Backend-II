using System;

namespace ExemploPOOPilares.classes
{
    public class Boletocs : Pagamento
    {
        private string CodigoDeBarras;

        Random r = new Random();
        public void Registrar(){
            CodigoDeBarras = r.Next(500000000).ToString();

            Console.WriteLine($"Boleto gerado com o código {CodigoDeBarras}");
            Console.WriteLine($"Boleto registrado com desconto, o valor agora é de {this.Valor * 0.88:C2}");
        }
    }
}