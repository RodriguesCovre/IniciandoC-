using System;

class exercicio{
    static void Main(){
        
        int pecaescolhida;
        double comissao;
        
        Console.WriteLine("Qual peça de roupa vai querer Comprar?");
        Console.WriteLine(1);
        Console.WriteLine(2);
        Console.WriteLine(3);
        Console.WriteLine("O valor da peça 1 é 14,50, o valor da peça 2 é 10,99 e o valor da peça 3 é 99.99");

        Console.WriteLine("Escolha e peça");
        pecaescolhida = Convert.ToInt32(Console.ReadLine());

        if(pecaescolhida == 1)
        {
            comissao = 14.50 * 0.05;
            Console.WriteLine("Venderdor vai receber " + comissao);
        }
        else if (pecaescolhida == 2)
        {
            comissao = 10.99 * 0.05;
            Console.WriteLine("Venderdor vai receber " + comissao);

        }
        else
        {
            comissao = 99.99 * 0.05;
            Console.WriteLine("Venderdor vai receber " + comissao);

        }
    }
}