using System;

abstract class Veiculo{
    protected  int velmax;
    protected  int velAtual;
    protected  bool ligado;

    public Veiculo(){
        ligado=false;
        velAtual=0;
    }

    public void setLigado(bool ligado){
        this.ligado=ligado;
    }
    public int getVelAtual(){
        return velAtual;
    }

    abstract public void aceleracao(int mult);
}

class Carro:Veiculo{
    public Carro(){
        velmax=120;
    }

    override public void aceleracao(int mult){
        velAtual+=10*mult;
    }
}
class Aula39{
    static void Main(){
        Carro carro = new Carro();

        carro.aceleracao(2);
        carro.aceleracao(2);
        carro.aceleracao(-1);

        Console.WriteLine(carro.getVelAtual());
    }
}