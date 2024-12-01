
    using System.Globalization;
    using Program19;

    namespace Programa
    {
        class Programa21
        {
            static double Pi = 3.14;
            static void Main(string[] args)
            {
                Console.Write("Digite um numero: ");
                double raio = double.Parse(Console.ReadLine());

                double Circ = Circunferencia(raio);
                double Vol = Volume(raio);

                Console.WriteLine("Cincurferencia: " + Circ.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Volume: " + Vol.ToString("F2", CultureInfo.InvariantCulture));
                Console.WriteLine("Volume: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
    
            }

            static double Circunferencia(double r){
                return 2*0 * Pi * r;
            }

            static double Volume(double r){
                return 4.0 / 3.0 * Pi * r * r * r;
            }
        } 
    }
