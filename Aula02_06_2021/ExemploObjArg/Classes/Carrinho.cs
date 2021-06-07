using System;
using System.Collections.Generic;

namespace ExemploObjArg.Classes
{
    public class Carrinho
    {
        // Criando propriedade que vai guardar o valor total dos produtos
        public float ValorTotal { get; set; }

        // Criando a lista que irá representar o carrinho
        List<Produto> carrinho = new List<Produto>();

        // Criando o método que irá adicionar um produto ao carrinho
        public void AdcProduto(Produto produto)
        {
            carrinho.Add(produto);
        }

        // Criando o método que irá remover um produto do carrinho
        public void RmvProduto(Produto produto)
        {
            carrinho.Remove(produto);
        }

        // Criando o método que irá listar os produtos do carrinho
        public void MostrarProdutos()
        {
            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"{p.Preco:C2} --- {p.Nome}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Não há nada para mostrar no carrinho, está vazio :(");
                Console.ResetColor();
            }

        }
        // Criando o método que irá calcular o total da compra
        public void MostrarTotal()
        {
            Console.ForegroundColor = ConsoleColor.Blue;

            if (carrinho != null)
            {
                foreach (Produto p in carrinho)
                {
                    ValorTotal += p.Preco;
                }
                Console.WriteLine($"\nValor total do carrinho: {ValorTotal:C2}\n");
            }
            else
            {
                Console.WriteLine($"Não há nada para mostrar no carrinho, está vazio :(");
            }
            Console.ResetColor();
        }

        // E ainda para alterar determinado produto
        public void AlterarProduto(int _codigo, Produto _novoProduto)
        {
            carrinho.Find(cadaLinha => cadaLinha.Codigo == _codigo).Nome = _novoProduto.Nome;
            carrinho.Find(cadaLinha => cadaLinha.Codigo == _codigo).Preco = _novoProduto.Preco;

            // É como se estivesse fazendo isso:
            // foreach (Produto cadaLinha in carrinho)
            // {
            //     if (cadaLinha.Codigo == _codigo)
            //     {
            //         cadaLinha.Nome = _novoProduto.Nome;
            //     }
            // }
        }
    }
}