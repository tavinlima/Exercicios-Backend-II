using System;
using System.Collections.Generic;
using ExemploListaObj.Classes;

namespace ExemploListaObj
{
    class Program
    {
        static void Main(string[] args)
        {
            //Criando a lista
            List<Produto> produtos = new List<Produto>();

            // CRUD - CREATE | READ | UPDATE | DELETE

            // Create
            // Adicionando produtos a lista por meio de instâncias com construtores
            produtos.Add(new Produto(1, "Box 'Percy Jackson e Os Olimpianos'", 150.02f));
            produtos.Add(new Produto(2, "Box 'Coleção Jogos Vorazes'", 130.08f));
            produtos.Add(new Produto(3, "Box 'Coleção Grandes Hits 2008'", 120.15f));
            produtos.Add(new Produto(4, "Box 'Diário de Um Banana'", 110.06f));
            produtos.Add(new Produto(5, "Box 'Coleção Como Treinar o Seu Dragão'", 85.15f));

            // Outro método por meio de uma instância básica
            Produto HqSpiderMan = new Produto();
            HqSpiderMan.Codigo = 6;
            HqSpiderMan.Nome = "HQ Ultimate Spíder-Man 2021 ed. 19";
            HqSpiderMan.Preco = 101.05f;

            produtos.Add(HqSpiderMan);

            // Read
            // Mostrando os produtos com foreach
            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome}  -  R$: {item.Preco}");
            }
            Console.WriteLine("");

            // Delete
            // Para remover algum item da lista, podemos escolher o índice de seu Array com o RemoveAt
            produtos.RemoveAt(2);

            // Ou por meio de uma expressão lambda e o método RemoveAll, buscando o item
            produtos.RemoveAll(item => item.Nome == "HQ Ultimate Spíder-Man 2021 ed. 19");

            // Update
            // Encontrar o produto a ser atualizado
            Produto atualizar = produtos.Find(item => item.Codigo == 1);

            // Mudar o valor desse produto
            atualizar.Preco = 99.99f;

            // Remover o item antigo
            produtos.RemoveAll(item => item.Codigo == 1);

            // Inserir o item atualizado
            produtos.Insert(0, atualizar);

            foreach (Produto item in produtos)
            {
                Console.WriteLine($"{item.Nome}  -  R$: {item.Preco}");
            }
            Console.WriteLine("");
        }
    }
}
