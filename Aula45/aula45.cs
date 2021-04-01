using System;
struct Carro
{
    public string nome;
    public string cor;

    public void info()
    {
        Console.WriteLine("nome.:{0}", this.nome);
        Console.WriteLine("cor..:{0}", this.cor);
        Console.WriteLine();
        Console.WriteLine("---------------------");
        Console.WriteLine();
    }
}
class Aula45
{
    static void Main()
    {
        //Criar um array do tipo Carro
        Carro[] carros=new Carro[5];

        carros[0].nome="HB20";
        carros[0].cor="pratra";

        carros[1].nome="golf";
        carros[1].cor="vermelho";

        carros[2].nome="camaro";
        carros[2].cor="amarelo";

        carros[3].nome="batmovel";
        carros[3].cor="preto";

        carros[4].nome="tesla";
        carros[4].cor="vermelho";


        for(int i=0;i<carros.Length;i++){
            carros[i].info();
        }
    }
}