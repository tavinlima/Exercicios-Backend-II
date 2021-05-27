using System;

namespace Atividade02.Classes
{
    public abstract class Jogador
    {
        public string nome;
        public int anoNasc;
        public string nacionalidade;
        public float altura;
        public float peso;
        protected int idadeApsntr;
        private int anoAtual = DateTime.Now.Year;

        public void MostrarDados()
        {
            Console.WriteLine("Insira o nome de jogador: ");
            nome = Console.ReadLine();

            Console.WriteLine("Insira o ano de nascimento de jogador:");
            anoNasc = int.Parse(Console.ReadLine());

            Console.WriteLine("Insira a nacionalidade de jogador:");
            nacionalidade = Console.ReadLine();

            Console.WriteLine("Insira a altura de jogador:");
            altura = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o peso de jogador:");
            peso = float.Parse(Console.ReadLine());

            Console.WriteLine($@"
=======================================
          Dados de jogador/a:
=======================================
Nome:               {nome}
Ano de nascimento:  {anoNasc}
Nacionalidade:      {nacionalidade}
Altura:             {altura}
Peso:               {peso}
=======================================
");
        }
        public int CalcIdade()
        {
            return anoAtual - anoNasc;
        }
    }
}