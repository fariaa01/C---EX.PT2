
using System.Security.Cryptography.X509Certificates;

namespace Program18
{
    class produto
    {
        public string Nome;

        public double Preco;

        public int Quantidade;

        public double total() {
            return Preco * Quantidade;
        }

        public void novoestoque(int quantidade){
            Quantidade = Quantidade + quantidade;

        }

        public void removidos(int novoestoque){
            Quantidade = Quantidade - Quantidade;
        }


        public override string ToString()
        {
            return Nome + " ,$" + Preco + "valor em estoque é de " + total;
        }
    }
}
