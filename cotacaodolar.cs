using System;

class Cotacao{
    static void Main(){
        int valoremdolar;
        int valoremreal;
        Console.WriteLine("O dolar esta $2, quanto voce deseja comprar? ");
        valoremdolar = Convert.ToInt32(Console.ReadLine());
        valoremreal = valoremdolar * 2;
        Console.WriteLine("Em real ficara {0} Reais", valoremreal);

    }
}