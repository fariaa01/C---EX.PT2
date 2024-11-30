

using System.Net.NetworkInformation;
using Program18;

namespace Program19
{
    class Aluno
    {
        public string Nome;

        public double Nota1,Nota2,Nota3;

        public double Notafinal(){
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado(){
            if(Notafinal() >= 60.0){
                return true;
            }
            else{
                return false;
            }
        }
    }
}
