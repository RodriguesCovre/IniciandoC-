using System;

class Conversao{
    static void Main(){
        float n4 = 20.5f;
        int n2 = (int)n4;
        Console.WriteLine(n2);

        string t1 = "3";
        int n1 = Convert.ToInt32(t1);
        Console.WriteLine(n1);
    }
}