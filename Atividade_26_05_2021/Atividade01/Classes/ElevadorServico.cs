using System;

namespace Atividade01.Classes
{
    public class ElevadorServico : Elevador
    {
        public void numCaixas(){
            Console.WriteLine("Deseja alterar o número de caixas para quanto? ");
            int qntdCaixas = int.Parse(Console.ReadLine());

            Console.WriteLine($"O número de caixas mudou para {qntdCaixas}");
        }
    }
}