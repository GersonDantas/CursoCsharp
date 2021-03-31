//propriedade accercrs (get e set), vou criar os metodos get e set dentro de uma propriedade...
using System;
class Carro{
    private int velMax;

    public int vm{
        get{//read only
            return velMax;
        }
        set{//Write only
            if(value <0){//o valor atribuido avm fica em "value"
                velMax=0;
            }else if(value>300){
                velMax=300;
            }else{
                velMax+=value;
            }
        }
    }
    public Carro(){
        this.velMax=120;
    }
}
class Aula41{
    static void Main(){
        Carro carro = new Carro();
        carro.vm=80;
        Console.WriteLine(carro.vm);
    }
}