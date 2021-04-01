//USAR SOMENTE OS MEMBROS OU PROPRIEDADES 'STATICS'

using System;
//fUNÇÃO JÁ EXISTENTE
class Mat{
    public static double pi = 3.14;
    public static int dobro(int n){
        return n*2;
    }
}

class Aula49{
    static void Main(){

        //os menbros sndo 'static' não precisa instanciar:
        //Mat m1 = new Mat()
        double y = Mat.pi;
        int n= 10;
        Console.WriteLine(Mat.dobro(n));
        Console.WriteLine(y);
    }
}