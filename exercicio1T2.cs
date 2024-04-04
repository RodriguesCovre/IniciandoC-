using System;
class Principal{
    static void Main()
    {
        Console.WriteLine("Escolha dois numeros");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());

        if(n1 > n2)
        {
            Console.WriteLine("N1 é mairo que N2");
        }
        else
        {
            Console.WriteLine("N2 é mairo que N1");
        }
    }
}