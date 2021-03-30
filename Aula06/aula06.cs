using System;
class Aula06{
    static void Main(){

        double valorCompra = 5.50;
        double valorVenda;
        double lucro=0.1;
        string produto = "pastel";
        valorVenda = valorCompra+(valorCompra*lucro);
        Console.WriteLine("produto........{0,15}",produto);
        Console.WriteLine("Val.compra........{0,15:c}",valorCompra);
        Console.WriteLine("lucro........{0,15:p}",lucro);
        Console.WriteLine("val.venda........{0,15:c}",valorVenda);
    }
}