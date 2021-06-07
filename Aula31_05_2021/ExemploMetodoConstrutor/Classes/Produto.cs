namespace ExemploMetodoConstrutor.Classes
{
    public class Produto
    {
        public Produto (){

        }

        public Produto(int ProdutoCodigo){
            Codigo = ProdutoCodigo;
        }

        public Produto(int ProdutoCodigo, string ProdutoNome, string ProdutoDescricao, int ProdutoEstoque){
            Codigo = ProdutoCodigo;
            Nome = ProdutoNome;
            Descricao = ProdutoDescricao;
            Estoque = ProdutoEstoque;
        }

        public int Codigo { get; set; }
        public string Nome { get; set; }
        
        public string Descricao { get; set; }
        public int Estoque { get; set; }
    }
}