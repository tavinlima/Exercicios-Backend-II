using System;

namespace ExemploPOOPilares.classes
{
    public class Debito : Cartaocs
    {
        private float saldo = 600f;

        public void Pagar(){
            float valor = this.Valor;
            
            if (valor > saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else{
                Console.WriteLine($"O valor de {valor:C2} foi pago com sucesso!");
            }
        }
    }
}