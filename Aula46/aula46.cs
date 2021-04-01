using System;

class Galinha{
    public string nomeGalinha;
    public int numOvo;
    public Galinha(string nomeGalinha){
        this.nomeGalinha=nomeGalinha;
        numOvo=0;
    }

    public Ovo botar(){
        numOvo++;
        return new Ovo(numOvo,nomeGalinha);
    }
}

class Ovo{
    public string minhaGalinha;
    private int numOvo;
    public Ovo(int numOvo,string minhaGalinha){
        this.numOvo=numOvo;
        this.minhaGalinha=minhaGalinha;
        Console.WriteLine("Ovo {0} criado, da galinha {1}",numOvo,minhaGalinha);
    }
}
class Aula46{
    static void Main(){
        Galinha g1=new Galinha("rapadura");
        Galinha g2=new Galinha("asamole");
        Galinha g3=new Galinha("ovoduro");

        g1.botar();
        g1.botar();
        g1.botar();
        Console.WriteLine();
        g2.botar();
        g2.botar();
        Console.WriteLine();
        g3.botar();
    }
}