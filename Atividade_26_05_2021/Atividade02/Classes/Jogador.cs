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

        public void MostrarDados(){
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
        public int CalcIdade(){
            return anoAtual - anoNasc;
        }
    }
}