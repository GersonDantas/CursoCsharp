using System;

class Veiculo//class base
{
    public int rodas;
    private bool ligado;
    
    public int velmax;

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
        if(ligado)
        {
            return "sim";
        }else{
            return "nao";
        }
    }
}

class Carro:Veiculo
{
    public string nome;

    public string cor;

    public Carro(string nome,string cor)
    {
        desligar();
        rodas=4;
        velmax=120;
        this.nome = nome;
        this.cor = cor;
    }
}

class Aula34
{
    static void Main()
    {
        Carro c1 = new Carro("Gol","Preto");

        Console.WriteLine("Nome:...........{0}",c1.nome);
        Console.WriteLine("cor:............{0}",c1.cor);
        Console.WriteLine("velciade maxima:{0}",c1.velmax);
        Console.WriteLine("Ligado?:........{0}",c1.getLigado());
    }
}