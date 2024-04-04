using System;
class Principal{
    static void Main(){
        Console.WriteLine("Qual é seu sexo? [F]:Mulher [M]:Homem");
        string sex = Console.ReadLine();

        if(sex == "F" || sex == "f")
        {
            Console.WriteLine("Você é mulher!");
        }
        else if(sex == "M" || sex == "m")
        {
            Console.WriteLine("Você é homem");
        }
        else
        {
            Console.WriteLine("Escolha F ou M");
        }
    }
}