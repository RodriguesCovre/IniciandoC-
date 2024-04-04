using System;
class Principal{
    static void Main(){
        Console.WriteLine("Digite um numero");
        int n1 = Convert.ToInt32(Console.ReadLine());

        if(n1 >= 1)
        {
            Console.WriteLine("Esse numero é possitivo");
        }
        else if(n1 == 0)
        {
            Console.WriteLine("esse numero é neutro");
        }
        else
        {
            Console.WriteLine("Esse numero é negativo");
        }
    }
}