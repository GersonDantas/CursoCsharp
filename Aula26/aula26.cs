using System;
class Program
{
    static void Main()
    {
        int divid,divis,quoc,rest;
        divid = Convert.ToInt32(Console.ReadLine()); 
        divis = Convert.ToInt32(Console.ReadLine()); 
        quoc = divide(divid,divis, out rest);

        Console.WriteLine("a divisao {0}/{1} é igual a {2}, com resto de {3}",divid,divis,quoc,rest);
    }

    static int divide(int dividendo, int divisor, out int resto)
    {
        int quociente = 0;
        quociente = dividendo/divisor;
        resto= dividendo%divisor;
        return quociente;
    }
}