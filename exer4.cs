using System;
class Principal{
    static void Main(){
        Console.WriteLine("Qual a Nota que Patrick tirou?");
        int n1 = Convert.ToInt32(Console.ReadLine());
        int n2 = Convert.ToInt32(Console.ReadLine());
        int media = (n1 + n2) / 2;

        if(media >= 7)
        {
            Console.WriteLine("Patrick voce foi aprovado");
        }
        else
        {
            Console.WriteLine("Patrick voce foi reprovado");
        }
    }
}