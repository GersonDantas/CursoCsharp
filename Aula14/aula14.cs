using System;
namespace Aula14
{
    class Program
    {
        static void Main()
        {
            //se(condição){faça}
            Console.WriteLine("Digite a nota");
            int nota = int.Parse(Console.ReadLine());
            string resultado;
            if(nota <= 60){
                if(nota>=40){
                        resultado = "recuperação";
                }else{
                    resultado = "reprovado";
                }
            }else{
                resultado = "Aprovado";
            }
            Console.WriteLine("Resultado: {0}",resultado);
        }
    }
}