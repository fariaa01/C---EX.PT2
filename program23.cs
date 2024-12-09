
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Security.Cryptography.X509Certificates;

namespace Programa23
{
    class Cliente
    {
        public int NumDaConta { get; private set ;}
        public string Nome { get; private set; }
        public double SaldoConta{ get;  private set; }

        public Cliente(int numero ,string nome){
            NumDaConta = numero;
            Nome = nome;
        }

        public Cliente (int numero, string nome , double depositoinicial){
            Deposito(depositoinicial);
        }
        
        public void Deposito (double quantia){
            SaldoConta = SaldoConta + quantia;
        }

        public void Saque (double quantia){
            SaldoConta = SaldoConta - quantia + 5.0;
        }

        public override string ToString()
        {
            return "Conta" + NumDaConta + ",Titular: " + Nome + ", Saldo da conta; " + SaldoConta;
        }
    }
}
