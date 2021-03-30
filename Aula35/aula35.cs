using System;

class Veiculo//class base
{
    private int rodas;
    private bool ligado;
    
    public int velmax;

    public Veiculo(int rodas){
        this.rodas = rodas;
    }

    public void ligar()
    {
        this.ligado = true;
    }
    public void desligar()
    {
        this.ligado = false;
    }

    public string getLigado()
    {
        return (ligado?"sim":"não");
    }

    public int getRodas()
    {
        return this.rodas;
    }

}

class Carro:Veiculo
{
    public string nome;

    public string cor;

    public Carro(string nome,string cor):base(4)
    {
        desligar();
        velmax=120;
        this.nome = nome;
        this.cor = cor;
    }
}

class CarroCombate:Carro
{
    public int monicao;
    public CarroCombate(int monicao):base("Foguinho","Verde")
    {
        ligar();
        velmax=80;
        this.monicao = monicao;
    }
}

class Aula35
{
    static void Main()
    {
        Carro c1 = new Carro("Gol","Preto");
        CarroCombate cc1 = new CarroCombate(500);

        Console.WriteLine("Nome:...........{0}",c1.nome);
        Console.WriteLine("cor:............{0}",c1.cor);
        Console.WriteLine("cor:............{0}",c1.getRodas());
        Console.WriteLine("velciade maxima:{0}",c1.velmax);
        Console.WriteLine("Ligado?:........{0}",c1.getLigado());

        Console.WriteLine("---------------------");

        Console.WriteLine("Nome:...........{0}",cc1.nome);
        Console.WriteLine("cor:............{0}",cc1.cor);
        Console.WriteLine("cor:............{0}",cc1.getRodas());
        Console.WriteLine("velciade maxima:{0}",cc1.velmax);
        Console.WriteLine("Ligado?:........{0}",cc1.getLigado());
        Console.WriteLine("municao:........{0}",cc1.monicao);
    }
}