using System;
using System.Collections.Generic;
using ExemploInterfaces.Interfaces;

namespace ExemploInterfaces.Classes
{
    public class Carrinho : ICarrinho
    {
        public float valorTotal { get; set; }

        // Criando a lista que irá representar o carrinho
        List<Produto> carrinho = new List<Produto>();

        public void Alterar(int _codigo, Produto produto)
        {
            carrinho.Find(cadaLinha => cadaLinha.Codigo == _codigo).Nome = produto.Nome;
            carrinho.Find(cadaLinha => cadaLinha.Codigo == _codigo).Preco = produto.Preco;
        }

        // Criando o método que irá adicionar um produto ao carrinho
        public void Cadastrar(Produto produto)
        {
            carrinho.Add(produto);
        }

        // Criando o método que irá remover um produto do carrinho
        public void Deletar(Produto produto)
        {
            carrinho.Remove(produto);
        }

        // Criando o método que irá listar os produtos do carrinho
        public void Listar()
        {
            foreach (Produto p in carrinho)
            {
                Console.WriteLine($"{p.Preco:C2} --- {p.Nome}");
            }
        }
    }
}