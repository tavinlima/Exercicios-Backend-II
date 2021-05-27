using System;

namespace Atividade02.Classes
{
    public class JogadorAtaque : Jogador
    {
        new int idadeApsntr = 35;
        public void Aposentar(){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nDaqui {(idadeApsntr - CalcIdade())} anos {nome} poderá se aposentar.\n");
            Console.ResetColor();
        }
    }
}