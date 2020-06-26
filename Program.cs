using System;
using System.Collections.Generic;

namespace Aula26Interfaces
{
    class Program
    {
        static void Main(string[] args)
              {
            Carrinho Jogos = new Carrinho();

            Produto p1 = new Produto(1, "The last of us", 200.00f);
            Produto p2 = new Produto(2, "Watch Dogs", 30.00f);
            Produto p3 = new Produto(3, "Dota 2", 0.00f);
            Produto p4 = new Produto(4, "Tomb Raider", 20.00f);
            Produto p5 = new Produto(5, "Far Cry Primal", 50.00f);
            
            Jogos.Adicionar(p1);
            Jogos.Adicionar(p2);
            Jogos.Adicionar(p3);
            Jogos.Adicionar(p4);
            Jogos.Adicionar(p5);

            Jogos.Remover(p3);

            Produto prodAlterado = new Produto(4, "CyberPunk 2077", 150.00f);
            Jogos.Alterar(4, prodAlterado);

            Jogos.Ler();
        }
        
    }
}
