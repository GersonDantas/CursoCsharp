using System;
class Jogador
{
    private int energia;
    private string nome;

    public Jogador(int energia,string nome)
    {
        this.energia = energia;
        this.nome = nome;
    }

    public int getEnergia()
    {
        return energia;
    }
    public string getNome()
    {
        return nome;
    }

    public void setEnergia(int e)
    {
        if(e<0)
        {
                // if(energia-e <0)
                // {
                //     energia = 0;
                // }else
                // {
                //     energia -=e;
                // }
                if(energia+e <0) //- com + é - (hehehe)
                {
                    energia = 0;
                }else
                {
                    energia +=e;
                }
        }else if(e>0)
        {
            if(energia+e >100)
            {
                energia = 100;
            }else
            {
                energia+=e;
            }
        }
    }
}
class Aula33
{
    static void Main()
    {
        Jogador j1 = new Jogador(100,"Paulo");

        j1.setEnergia(-30);

        Console.WriteLine("Nome ....: {0}",j1.getNome());
        Console.WriteLine("Nome ....: {0}",j1.getEnergia());
    }
}