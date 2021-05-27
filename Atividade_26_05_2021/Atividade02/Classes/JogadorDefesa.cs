using System;

namespace Atividade02.Classes
{
    public class JogadorDefesa : Jogador
    {
        new int idadeApsntr = 40;
        public void Aposentar(){
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"\nDaqui {(idadeApsntr - CalcIdade())} anos {nome} poderá se aposentar.\n");
            Console.ResetColor();        }
    }
}