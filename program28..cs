using System;
using System.Collections.Generic;
using System.Globalization;
using Course;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            List<emprego> emprego = new List<emprego>();

            Console.Write("Quantos funcionarios voce quer registrar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Funcionario #{i + 1} ");

                Console.Write("ID:");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Nome:");
                string name = Console.ReadLine();

                Console.Write("Salario: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                emprego.Add(new emprego(id, name, salary));
            }

            Console.Write("Digite o id do funcionario que recebera o aumento: ");
            int nId = int.Parse(Console.ReadLine()); 

            emprego emp = emprego.Find(e => e.Id == nId);

            if(emprego != null)
            {
                Console.Write("Digite a porcentagem do aumento: ");
                double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.AumentoTrabalho(porcentagem);
            }
            else
            {
                Console.WriteLine("Esse id não existe");
            }

            Console.WriteLine("\nListas atualizadas dos funcionarios: ");
            foreach(var e in emprego)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}