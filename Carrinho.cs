using System.Collections.Generic;

namespace Aula26Interfaces
{
    public class Carrinho : ICarrinho
    {
        public float ValorTotal{ get; set;}
        List<Produto> carrinho = new List<Produto>();
        public void Adicionar(Produto _produto)
        {
            carrinho.Add(_produto);
        }

        public void Alterar(int Codigo, Produto _AlterarProduto)
        {
            carrinho.Find(x => x.Codigo == Codigo).Nome = _AlterarProduto.Nome;
            carrinho.Find(x => x.Codigo == Codigo).Preco = _AlterarProduto.Preco;
            
        }

        public void Ler()
        {
            foreach(Produto item in carrinho){
                System.Console.WriteLine($"{item.Nome} - R${item.Preco} REAIS.");
            }
        }

        public void Remover(Produto _produto)
        {
            carrinho.Remove(_produto);
        }
    }
}