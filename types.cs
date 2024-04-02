using System;
 public class types{
    static void Main(){
        Console.WriteLine("Digite Algo");
        int res = Convert.ToInt32(Console.ReadLine());
     
    if(res.GetType() == typeof(string))
    {
        Console.WriteLine("É um texto");

    }   
    else
    {
        Console.WriteLine("É um numero");
    } 
    }
 }