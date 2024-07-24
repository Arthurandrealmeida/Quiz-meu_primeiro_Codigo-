using System;

public class HelloWorld
{
    public static void Main()
    {
        
        Console.WriteLine("Quanto é 1 + 1?");
        int resposta1 = int.Parse(Console.ReadLine());

        if (resposta1 == 2)
        {
            Console.WriteLine("Você acertou!");
        }
        else
        {
            Console.WriteLine("Você errou!");
        }

        
        Console.WriteLine("Quanto é 2 + 2?");
        int resposta2 = int.Parse(Console.ReadLine());

        if (resposta2 == 4)
        {
            Console.WriteLine("Acertou em CHEIO!");
        }
        else
        {
            Console.WriteLine("Infelizmente errou.");
        }

        
        Console.WriteLine("Quanto é 2 + 3?");
        int resposta3 = int.Parse(Console.ReadLine());

        if (resposta3 == 5)
        {
            Console.WriteLine("MUITO BEM!");
        }
        else
        {
            Console.WriteLine("Errou :(");
        }
    }
}
