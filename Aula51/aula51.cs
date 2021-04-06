//Argumentos ao iniciar programa
using System;
class Aula51{
    static void Main(string[] args){//eu posso passar um array de string
       //fazer a verificação de argumentos
       if(args.Length >0){
           Console.WriteLine("QUantidade de argumentos: {0}",args.Length);
           int res = 0;
           for(int i = 0; i < args.Length; i++){
               res += Int32.Parse(args[i]);//tem que passar para inteiros, pq é uma string
           }
           Console.WriteLine("soma: {0}", res);
       }else{
           Console.WriteLine("Não foram passados argumentos");
       }
    }
}