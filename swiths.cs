using System;

class Principal{
    static void Main(){
        Console.WriteLine("Escolha uma opção");
        Console.WriteLine("[1] - opção");
        Console.WriteLine("[2] - opção");
        Console.WriteLine("[3] - opção");
        int res = Convert.ToInt32(Console.ReadLine());

        switch(res)
        {
            case 1:
            Console.WriteLine("Opção 1");
            break;

            case 2:
            Console.WriteLine("Opção 2");
            break;

            case 3:
            Console.WriteLine("opção 3");
            break;

            default:
            Console.WriteLine("não é uma opção");
            break;
        }

    }
}