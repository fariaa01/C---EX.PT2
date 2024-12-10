

using System.Runtime;
using System.Runtime.Serialization.Formatters;

namespace programa26
{
    class programa26
    {

        static void Main(string[] args){

            int n = int.Parse(Console.ReadLine());

            Produto [] vect = new Produto[n];

            for(int i = 0; i < n; i++){
                string nome = Console.ReadLine();
                double valor = double.Parse(Console.ReadLine());
                vect [i] = new Produto {NomeDoProduto = nome, ValorDoProduto = valor }; 
            }

            double sum = 0.0;
            for(int i = 0; i < n; i++){
                sum += vect[i].ValorDoProduto;
            }

            double avg = sum / n;

            Console.WriteLine("O preço médio é de: " + avg);

        } 
    }
}
