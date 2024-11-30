
using Program19;

namespace Programa
{
    class Programa19
    {
        static void Main(string[] args)
        {
        
           funcionario f = new funcionario();

           Console.Write("Digite o nome do funcionario: ");
           f.Nome = Console.ReadLine();

           Console.Write("Digite o salario do funcionario: ");
           f.Salario = double.Parse(Console.ReadLine());

           Console.Write("Digite o imposto: ");
           f.Imposto = double.Parse(Console.ReadLine());

           Console.WriteLine();
           Console.WriteLine("Funcioaario: " + f);

           Console.Write("Digite a porcentagem para aumentar o salario do funcionario: ");
           double aumento = double.Parse(Console.ReadLine());
           f.SalarioAumento(aumento);

           Console.WriteLine();
           Console.WriteLine("Dados atualizados: " + f);
        } 
    }
}
