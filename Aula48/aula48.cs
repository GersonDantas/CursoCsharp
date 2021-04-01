//RECURSIVIDADE
using System;

class Calc{
    public int soma(params int[]n){
        int somador=0;
        for(int i=0;i<n.Length;i++){
            somador+=n[i];
        }
        return somador;
    }
    public double soma(params double[]n){
        double somador=0;
        for(int i=0;i<n.Length;i++){
            somador+=n[i];
        }
        return somador;
    }
    //fatorial = 5*4*3*2*1 = n*n-1
    public int fat(int n){
        int res;
        if(n<=1){  //controle de parada
            res=1;
        }else{
            res=n*fat(n-1);
        }
        return res;
    }
}
class Aula48{
    static void Main(){

        Calc calc = new Calc();

        var res = calc.soma(10.5,5.3,7.4,4.9);
        var resp = calc.fat(5);

        Console.WriteLine(res);
        Console.WriteLine();
        Console.WriteLine(resp);
    }
}