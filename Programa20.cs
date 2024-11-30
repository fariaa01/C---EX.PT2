
using Program19;

namespace Programa
{
    class Programa20
    {
        static void Main(string[] args)
        {
            Aluno aluno = new Aluno();

            Console.Write("Digite seu nome: ");
            aluno.Nome = Console.ReadLine();

            Console.Write("Digite as tres notas: ");
            aluno.Nota1 = double.Parse(Console.ReadLine());
            aluno.Nota2 = double.Parse(Console.ReadLine());
            aluno.Nota3= double.Parse(Console.ReadLine());

            Console.WriteLine("Nota final = " + aluno.Notafinal());

            if(aluno.Aprovado()){
                Console.WriteLine("Aprovado");
            }
            else{
                Console.WriteLine("Reprovado");
            }

            } 
    }
}
