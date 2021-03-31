using System;
//Para saber a sequencia de execução das classes...
class Base{
    public Base(){
        Console.WriteLine("Esta é a classe base");
    }

    virtual public void info(){}//se eu vou sobrescrever nao precisa de conteudo
}
class Derivada1:Base{
    public Derivada1(){
        Console.WriteLine("Esta é a classe derivada1");
    }
    override public void info()
    {
        Console.WriteLine("Derivada1");
    }
}
class Derivada2:Derivada1{
    public Derivada2(){
        Console.WriteLine("Esta é a classe derivada2");
    }
    override public void info()
    {
        Console.WriteLine("Derivada1");
    }
}
class Aula38
{
        static void Main(){
            Base Ref;

            Derivada1 d1 = new Derivada1();
            Derivada2 d2 = new Derivada2();

            Ref=d1;
            Ref.info();
        }
}