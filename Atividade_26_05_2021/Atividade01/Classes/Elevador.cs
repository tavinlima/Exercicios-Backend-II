using System;

namespace Atividade01.Classes
{
    public abstract class Elevador
    {
        protected int andarAtual;
        protected int andar;
        protected int totalAndares;
        protected int capacidade;
        protected int qntdPessoas;

        public int Inicializar(){
            Console.WriteLine("Qual a capacidade do elevador? ");
            capacidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Quantos andares tem o elevador? ");
            totalAndares = int.Parse(Console.ReadLine());

            andarAtual = 0;

            Console.WriteLine("Elevador iniciando...");

            return  capacidade;
        }

        public void Entrar(){
            Console.WriteLine("(Por favor, só utilize caso todos forem para o mesmo andar) Quantas pessoas estão no elevador? ");
            qntdPessoas = int.Parse(Console.ReadLine());

            do
            {
            if (qntdPessoas <= capacidade)
            {
                Console.WriteLine("Bem vindo!");
            }
            else{
                Console.WriteLine("Capacidade máxima atingida.");
            } 
            } while (qntdPessoas > capacidade);
        }

        public void Sair(){
            if (qntdPessoas >= 1)
            {
                qntdPessoas = qntdPessoas - 1;
                Console.WriteLine("Adeus :)");
            }
            else{
                Console.WriteLine("Não tem ninguém para sair...");
            }
        }

        public void Subir(){
            do
            {
            if (andarAtual != totalAndares)
            {
                Console.WriteLine("Para onde deseja subir? ");
                andar = int.Parse(Console.ReadLine());
                Console.WriteLine($@"

Subindo...
                
Você chegou ao {andar}º andar!

                ");
            }
            else{
                Console.WriteLine("Operação impossível");
            }
            } while (andarAtual == totalAndares);
            andarAtual = andar;
        }

        public void Descer(){
            do
            {
            if (andarAtual != 0)
            {
                Console.WriteLine("Para onde deseja descer? ");
                andar = int.Parse(Console.ReadLine());
                 Console.WriteLine($@"

Descendo...
                
Você chegou ao {andar}º andar!

                ");
            }
            else if (andarAtual == 1){
                Console.WriteLine("Operação impossível");
            }
            } while (andarAtual == 0);
        }
    }
}