using System.Globalization;
using System.Net.Security;
using System.Security.Cryptography;
using Program18;

namespace Programa
{
    class Programa18
    {
        static void Main(string[] args)
        {
        
           produto p = new produto();
           produto e = new produto();
           

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome do produto: ");
            p.Nome = Console.ReadLine();

            Console.Write("Qual o preco: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Qual é a quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto é: " + p);

            Console.Write("Digte a quantidade de produtos que foram adicionados no estoque: ");
            int qtde = int.Parse(Console.ReadLine());
            p.novoestoque(qtde);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " +  p);

            Console.Write("Digite o numero de produtos que podem ser removidos: ");
            int rmv = int.Parse(Console.ReadLine());
            p.removidos(rmv);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados:" + p);
  
        } 
    }
}
