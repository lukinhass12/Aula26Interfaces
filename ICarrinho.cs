namespace Aula26Interfaces
{
    public interface ICarrinho
    {
        //CRUD = CREATE, READ, U
         void Ler();
         void Adicionar(Produto _produto);
         void Remover(Produto _produto);
         void Alterar(int Codigo, Produto _AlterarProduto);
    }
    }
    