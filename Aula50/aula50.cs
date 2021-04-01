//DELEGATE: pode fazer referência a métodos
using System;
delegate int Op(params int[]n);
delegate int OpD( int n);
class Mat{
    public static int soma(params int[]n){
        int somador=0;
        for(int i=0;i<n.Length;i++){
            somador+=n[i];
        }
        return somador;
    }
    public static int mult(params int[]n){
       int somador=0;
        for(int i=0;i<n.Length;i++){
            somador*=n[i];
        }
        return somador;
    }
    public static int dobro(int n){
        return n * 2;
    }


}
class Aula50{
    static void Main(){
        int res;
        Op op = new Op(Mat.soma);
        res = op(10,3,4);
        Console.WriteLine("soma é: {0}",res);
        op = new Op(Mat.mult);
        res = op(10,3,5,7);
        Console.WriteLine("multiplicação é: {0}",res);
        OpD opd = new OpD(Mat.dobro);
        res = opd(10);
        Console.WriteLine("dobro é: {0}",res);

    }
}