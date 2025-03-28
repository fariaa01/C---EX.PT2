using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class emprego
    {
        public int Id {  get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public emprego(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
            public void AumentoTrabalho(double porcentagem)
        {
            Salary += Salary * (porcentagem / 100.0);
        }

        public override string ToString()
        {
            return $"{Id}, {Name}, {Salary.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
