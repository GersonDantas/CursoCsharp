using System;
public class Jogador
{
    public int energia;
    public bool vivo;

    public string nome;
    //método construtor, todo método tem um construtor, mesmo se eu não fizer,tem o nome da class
    public Jogador(string n)
    {
        energia = 100;
        vivo = true;
        nome = n;
    }
    //Ele vai ser chamado quando nao precisar mais do objetto, precisa ser antecipado por um tiu '~'
    ~Jogador()
    {
        Console.WriteLine("Jogador foi {0} destruido",nome);
    }

}

class Aula29
{
    static void Main()
    {
        string nome1;
        Console.WriteLine("digite o nome do Jogador 1");
        nome1 = Console.ReadLine();
        Jogador j1=new Jogador(nome1);//vai la na meória ram e aloca o endereço para esse valor
        Jogador j2=new Jogador("romario");
        Jogador j3=new Jogador("gerson");

        j1.energia = 50;
        Console.WriteLine("Nome do jogador 1: {0}",j1.nome);
        Console.WriteLine("Nome do jogador 1: {0}",j2.nome);
    }
}