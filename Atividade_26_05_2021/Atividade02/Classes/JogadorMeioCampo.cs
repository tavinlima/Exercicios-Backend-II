using System;

namespace Atividade02.Classes
{
    public class JogadorMeioCampo : Jogador
    {
        new int idadeApsntr = 38;
        public void Aposentar(){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nDaqui {(idadeApsntr - CalcIdade())} anos {nome} poderá se aposentar.\n");
            Console.ResetColor();
        }
    }
}