using System;

class Entrada
{
    static void Main(string[] args){
        Console.WriteLine("digita");
        string input = Console.ReadLine();
    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("voce nao digitou algo");
    }
    else
        {
            Console.WriteLine("obrigado" + input);
           
        }
    }
}