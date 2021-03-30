using System;
//static, endereço estatico na memoria, todos os membros tem que ser estáticos tbm
static public class Jogador
{
    static public int energia;
    static public bool vivo;

    static public string nome;
    //método construtor, todo método tem um construtor, mesmo se eu não fizer,tem o nome da class

    static public void iniciar(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    static public void info()
    {
        Console.WriteLine("Nome do jogador:...........{0}",nome);
        Console.WriteLine("energia do jogador esta em:{0}",energia);
        Console.WriteLine(vivo ? "jogador vivo": "jogador morto");
    }
}

class Inimigo
{
    static public bool alerta;
    public string nome;

    public Inimigo(string n)
    {
        alerta = false;
        nome = n;
    }

    public void info()
    {
        Console.WriteLine(nome);
        Console.WriteLine(alerta);
        Console.WriteLine("--------------------");
    }

}

class Aula31
{
    static void Main()
    {
        Jogador.iniciar("Bruno");
        //com static eu acesso diretamente a classe
        Jogador.info();

        Console.WriteLine();

        Inimigo n1 = new Inimigo("Bruno");
        Inimigo n2 = new Inimigo("cabanhas");
        Inimigo n3 = new Inimigo("caragunes");

        Inimigo.alerta=true;

        n1.info();
        n2.info();
        n3.info();
    }
}