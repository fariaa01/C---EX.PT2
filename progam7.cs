
    namespace Programa22
    {
        class ConversorDeMoeda
        {
             public static double iof = 6.0;

            public static double ValorAserPago(double dolar, double valor){
                double total = dolar*valor;
                return total + total * iof /100;
            }
        } 
    }
