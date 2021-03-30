using System;
public class Jogador
{
    public int energia;
    public bool vivo;

    public string nome;
    //método construtor, todo método tem um construtor, mesmo se eu não fizer,tem o nome da class

    public Jogador()
    {
        energia = 100;
        vivo = true;
        nome = "default";
    }
    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    public Jogador(string n,int e)
    {
        energia = e;
        vivo = true;
        nome = n;
    }
    public Jogador(string n, int e,bool v)
    {
        energia = e;
        vivo = v;
        nome = n;
    }

    public void info()
    {
        Console.WriteLine("Nome do jogador:...........{0}",nome);
        Console.WriteLine("energia do jogador esta em:{0}",energia);
        Console.WriteLine(vivo ? "jogador vivo": "jogador morto");
    }
}

class Aula30
{
    static void Main()
    {
        Jogador j1=new Jogador();//vai la na meória ram e aloca o endereço para esse valor
        Jogador j2=new Jogador("romario");
        Jogador j3=new Jogador("gerson",70);
        Jogador j4=new Jogador("remeraldo",0,false);

       j1.info();
       j2.info();
       j3.info();
       j4.info();
    }
}