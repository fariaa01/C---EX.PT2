
using System.Numerics;
using programa26;

namespace programa27
{
    class programa27
    {
        static void Main(string[] args){

            Console.Write("Quantos quartos foram alugados: ");
            int quartos = int.Parse(Console.ReadLine());

            Quartos [] vect = new Quartos[10];

            for(int i = 1; i <= quartos; i++){
                Console.Write("");
                Console.WriteLine($"Aluguel #{i}:");
                Console.Write("Nome: ");
                string nomedocliente = Console.ReadLine();

                Console.Write("Email: ");
                string emaildocliente = Console.ReadLine();

                Console.Write("Numero do quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Quartos(nomedocliente, emaildocliente);
            }

            Console.Write("");
            for(int i = 0; i < 10; i++){
                if(vect[i] != null){
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
            
            

            


        } 
    }
}
