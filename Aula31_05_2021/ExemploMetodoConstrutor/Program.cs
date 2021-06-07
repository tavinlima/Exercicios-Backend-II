using System;
using ExemploMetodoConstrutor.Classes;

namespace ExemploMetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de Métodos Construtores");

            Produto p = new Produto();
            Console.WriteLine("Primeiro produto (Construtor sem argumentos");
            Console.WriteLine($@"
Código: {p.Codigo}
Nome: {p.Nome}
Descrição: {p.Descricao}
Itens disponíveis no estoque: {p.Estoque}
            ");

            Produto p2 = new Produto(6456);
            Console.WriteLine("Primeiro produto (Construtor com 1(um) argumento");
            Console.WriteLine($@"
Código: {p2.Codigo}
Nome: {p2.Nome}
Descrição: {p2.Descricao}
Itens disponíveis no estoque: {p2.Estoque}
            ");

            Produto p3 = new Produto(6789, "Pão de queijo!", "Pão de Queijo que encanta qualquer um!", 6);
            Console.WriteLine("Primeiro produto (Construtor com 4 (quatro) argumentos");
            Console.WriteLine($@"
Código: {p3.Codigo}
Nome: {p3.Nome}
Descrição: {p3.Descricao}
Itens disponíveis no estoque: {p3.Estoque}
            ");
        }
    }
}
