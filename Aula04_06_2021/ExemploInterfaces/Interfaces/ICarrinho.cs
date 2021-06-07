using ExemploInterfaces.Classes;

namespace ExemploInterfaces.Interfaces
{
    public interface ICarrinho
    {
        // A interface é um tipo de "contrato" que obriga a implementação dos métodos que dela herdarem
        void Listar();
        void Cadastrar(Produto produto);
        void Alterar(int _codigo, Produto produto);
        void Deletar(Produto produto);
    }
}