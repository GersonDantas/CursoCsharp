using System;
class Program
{
    static void Main()
    {
        int v1,v2;
        v1 = Convert.ToInt32(Console.ReadLine());
        v2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("a soma de {0} e {1} é: {2}", v1,v2,somar(v1,v2));
    }

    static int somar(int n1, int n2)
    {
        int res = n1+n2;
        return res;
    }
}