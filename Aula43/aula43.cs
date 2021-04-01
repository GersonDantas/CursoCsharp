//interface: Não podem ter propriedades, e todas os objetos que usarem elas teram que implementar seus metodos

using System;
public interface Veiculo{
    void ligar();
    void desligar();
    void info();
}

public interface Combate{
    void disparar();
}

class Carro:Veiculo, Combate{
    private int municao;
    public bool ligado;
    public Carro(){
        setMunicao(100);
    }
    public void ligar(){
        this.ligado=true;
    }   
    public void desligar(){
        this.ligado=false;
    } 

    public void setMunicao(int qtde){
        this.municao = qtde;
    }

    public void info(){}

    public void disparar(){}  
}
class Aula43{
    static void Main(){
        Carro c1=new Carro();
    }
}