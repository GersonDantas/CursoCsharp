using System;
class Veiculo{
    public int velAtual;
    private int velMax;
    protected bool ligado;//as classes dericvadas podem acessar
    public Veiculo(int velMax){
        velAtual=0;
        this.velMax=velMax;
        ligado=false;
    }
    public int getVelMax(){
        return velMax;
    }
}
class Carro:Veiculo{
    public string nome;
    public Carro(string nome, int vm):base(vm){//o parametro vm esta inicializando a class base
        this.nome = nome;
        ligado=true;
    }
    public bool getLigado(){
        return ligado;
    }
}
class Aula36
{
    static void Main()
    {
        Carro carro=new Carro("Bonitão",180);

        Console.WriteLine("Nome:{0}",carro.nome);
        Console.WriteLine("Nome:{0}",carro.velAtual);
        Console.WriteLine("Nome:{0}",carro.getVelMax());
        Console.WriteLine(carro.getLigado()?"Carro ligado":"Carro desligado");
    }
}