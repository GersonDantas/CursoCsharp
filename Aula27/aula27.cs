using System;
class Program
{
    static void Main()
    {
        soma(2,4);
    }

    static void soma(params int[]n)
    {
        int res = 0 ;
        if(n.Length<1)
        {
            Console.WriteLine("Não existe valorres");
        }else if(n.Length<2)
        {
            Console.WriteLine("só um valor: {0}",n[0]);
        }else
        {
            for(int i = 0; i < n.Length;i++)
            {
                res +=n[i];
            }
            Console.WriteLine("O resultado da soma dos valores é: {0}",res);
        }
    }
}