using System;
namespace Aula12
{
    class Program
    {
        static void Main()
        {
            //se(condição){faça}
            Console.WriteLine("Digite a nota");
            int nota = int.Parse(Console.ReadLine());
            string resultado = "Aprovado";
            if(nota < 60){
                resultado = "reprovado";
            }
            Console.WriteLine("Resultado: {0}",resultado);
        }
    }
}