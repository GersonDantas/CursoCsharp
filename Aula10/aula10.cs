using System;
namespace Aula10
{
    class Program
    {

        //criar um tipo de variável

        enum DiasSemana
        {
            Domingo,
            segunda,
            terca, 
            quarta, 
            quinta,
            sexta,
            sabado
        }
        static void Main()
        {
            DiasSemana ds = DiasSemana.sabado;

            Console.WriteLine(ds);
        }
    }
}