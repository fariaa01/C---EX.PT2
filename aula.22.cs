
using System.Globalization;
using System.Runtime.InteropServices;

namespace Programa22
    {
        class Programa22
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Qual é a cotação do dolar: ");
                double dolar = double.Parse(Console.ReadLine());

                Console.WriteLine("Quantos dolares voce vai pegar: ");
                double valor = double.Parse(Console.ReadLine());

                double result = ConversorDeMoeda.ValorAserPago(dolar, valor);

                Console.WriteLine("Valor a ser pago: "+ result.ToString(CultureInfo.InstalledUICulture));
            }
        } 
    }
