using System;

class Cadastro{
    static void Main(){
        Console.WriteLine("Escreva seu Nome");
        string input = Console.ReadLine();


    if(string.IsNullOrEmpty(input)){
            Console.WriteLine("Por favor Escreva seu nome");
        }
        else{
            Console.WriteLine(input);
        }
    }
}