using System;
using ExemploObjArg.Classes;

namespace ExemploObjArg
{
    class Program
    {
        static void Main(string[] args)
        {
            // Informando os atributos do primeiro objeto
            Console.WriteLine("Qual o código do produto? ");
            int cdgProduto = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o nome do produto? ");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine("Qual o preço do produto? ");
            float precoProduto = float.Parse(Console.ReadLine());

            // Criando os produtos
            Produto p1 = new Produto(cdgProduto, nomeProduto, precoProduto);
            Produto p2 = new Produto(040506, "Manual para treinar o seu dragão bebê", 89.12f);
            Produto p3 = new Produto(070809, "Melhores receitas da Fada Maria Braga", 76.15f);
            Produto p4 = new Produto(101112, "Você realmente conhece seu inquilino? Entrevistas com duendes", 50.50f);
            Produto p5 = new Produto(131415, "História em quadrinhos: O humano e o gato", 49.99f);

            Produto p6 = new Produto(666666, "Os contos da vizinha fofoqueira", 666.66f);

            // Adicionando ao carrinho
            Carrinho carrinho = new Carrinho();
            carrinho.AdcProduto(p1);
            carrinho.AdcProduto(p2);
            carrinho.AdcProduto(p3);
            carrinho.AdcProduto(p4);
            carrinho.AdcProduto(p5);

            // Mostrar o carrinho completo
            carrinho.MostrarProdutos();

            Console.WriteLine("Deseja alterar algum produto? S/N");
            string alterarPrdt = Console.ReadLine() .ToUpper() .Substring(0, 1);

            switch (alterarPrdt)
            {
                case "S":
                Console.WriteLine("Qual código do produto? ");
                cdgProduto = int.Parse(Console.ReadLine());

                carrinho.AlterarProduto(cdgProduto, p6);
                carrinho.MostrarProdutos();
                    break;
                case "N":
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Obrigado por usar nossa loja, tenha um ótimo dia :) ");
                Console.ResetColor();
                    break;
                default:
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Obrigado por usar nossa loja, tenha um ótimo dia :) ");
                Console.ResetColor();
                    break;
            }
        }
    }
}
