

namespace Program19
{
    class funcionario
    {
        public string Nome;

        public double Salario;

        public double Imposto;


        public double SalarioBruto(){
            return  Salario - Imposto;
        }

        public void SalarioAumento(double aumento){
            SalarioBruto = SalarioBruto + (SalarioBruto*aumento / 100.0);
        }

        public override string ToString()
        {
            return Nome + ", $" + SalarioBruto;
        }
    }
}
