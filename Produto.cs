namespace Aula26Interfaces
{
    public class Produto
    {
        public int Codigo {get; set;}
        public string Nome {get; set;}
        public float Preco {get; set;}
        public Produto(int Codigo, string Nome, float Preco){
            this.Codigo = Codigo;
            this.Nome = Nome;
            this.Preco = Preco;        
        }

        public Produto()
        {
        }
    }
}