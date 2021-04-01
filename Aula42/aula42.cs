//INDEXADORES: permiteo objeto ser usado como array...
using System;
class Carro{
    private int[] velMax=new int[]{80,60,70,100,200,};

    public int this[int i]{//no lugar de 'vm' usamos o this, que diz que o indexador é referente ao objeto
        get{//read only
            return velMax[i];//onde tiver chamada da propriedade tenho que usar o indice
        }
        set{//Write only
            if(value+velMax[i] <0){//o valor atribuido avm fica em "value"
                velMax[i]=0;
            }else if(value+velMax[i]>300){
                velMax[i]=300;
            }else{
                velMax[i]+=value;
            }
        }
    }
    public Carro(){
    }
}
class Aula42{
    static void Main(){
        Carro carro = new Carro();
        carro[3]=-20;//agora eu chamo o objeto como um array
        Console.WriteLine("Velocidade do carro é: {0}",carro[3]);
    }
}