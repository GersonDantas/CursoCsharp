using System;
class Aula08{
    static void Main(){

        int v1,v2,soma;
        string nome;

        
        Console.Write("Digite primeiro valor:");
        v1= ParsConsole.ReadLine();
        Console.Write("Digite segundo valor:");
        v2= Console.ReadLine();
        soma = v1+v2;
        Console.WriteLine("A soma de {0} mais {1} é igual a {2}",v1,v2,soma);
    }
}