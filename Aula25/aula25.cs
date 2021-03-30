using System;
class Program
{
    static void Main()
    {
        int num, num1 = 50;
        dobrar2(ref num);
        dobrar1( num1);
        Console.WriteLine(num);
        Console.WriteLine(num1);
    }

    static void dobrar2(ref int valor)
    {
        valor *=2;
    }
    static void dobrar1(int valor)
    {
        valor *=2;
    }
}