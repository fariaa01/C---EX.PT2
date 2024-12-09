
using Program18;

namespace Programa23
    {
        class Programa23
        {
            static void Main(string[] args)
            {
                Cliente contacliente;

                Console.Write("Entre com o numero da conta: ");
                int numero = int.Parse(Console.ReadLine());
                
                Console.Write("Entre com o titular da conta: ");
                string nome = Console.ReadLine();

                Console.Write("Havera um deposito inicial: ");
                char resp = char.Parse(Console.ReadLine());

                if (resp == 's'){
                    Console.Write("Digite o valor do deposito inicial: ");
                    double dep = double.Parse(Console.ReadLine());
                    contacliente = new Cliente(numero, nome, dep);
                }

                else{
                    contacliente = new Cliente(numero,nome);
                }

                Console.Write("");
                Console.WriteLine(contacliente);
                Console.Write("");

                Console.Write("Entre com um valor de deposito: ");
                double quantia = double.Parse(Console.ReadLine());
                contacliente.Deposito(quantia);
                Console.Write("Dados atualizados da conta: ");
                Console.WriteLine(contacliente);

                
            }
        } 
    }
