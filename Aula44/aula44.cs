using System;
struct Carro
{
    public string marca;
    public string nome;
    public string cor;

    public Carro(string marca, string nome, string cor)
    {
        this.marca = marca;
        this.nome = nome;
        this.cor = cor;
    }

    public void info()
    {
        Console.WriteLine("Marca:{0}", this.marca);
        Console.WriteLine("nome.:{0}", this.nome);
        Console.WriteLine("cor..:{0}", this.cor);
    }
}
class Aula44
{
    static void Main()
    {
        Carro c1 = new Carro("Wolkisvagem", "HBV", "cinza");
        c1.info();

    }
}