using System;
//Para saber a sequencia de execução das classes...
class Base{
    public Base(){
        Console.WriteLine("Esta é a classe base");
    }
}
class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Esta é a classe derivada1");
    }
}
class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Esta é a classe derivada2");
    }
}
class Aula37
{
        static void Main(){
            Derivada2 d = new Derivada2();
        }
}