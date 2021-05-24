using System;

namespace ExemploPOOPilares.classes
{
    public class Credito : Cartaocs
    {
        private float limite = 3000f;

        public void Pagar(){
            float valor = this.Valor;
            int vezes;

            if (valor > limite)
            {
                Console.WriteLine("O seu limite não é suficiente para pagar esse valor :(");
            } else{
                do
                {
                    Console.WriteLine($"Em quantas vezes deseja parcelar o valor {valor:C2}? (de 1 à 12)");
                    vezes = int.Parse(Console.ReadLine());

                    if (vezes >= 1 && vezes <= 6)
                    {
                        Console.WriteLine($"Você optou por parcelar em {vezes}, dessa forma o juros erá de 5% do valor total");
                        Console.WriteLine($"Você pagará {valor * 1.05:C2} em {vezes} de {(valor * 1.05) / vezes:C2}");
                    }
                    else if (vezes >= 7 && vezes <= 12)
                    {
                        Console.WriteLine($"Você optou por parcelar em {vezes}, dessa forma o juros erá de 8% do valor total");
                        Console.WriteLine($"Você pagará {valor * 1.08:C2} em {vezes} de {(valor * 1.08) / vezes:C2}");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido! Escolha um número de parcelas entre 1 e 12.");
                    }
                } while (vezes < 1 || vezes > 12);
            }
        }
    }
}