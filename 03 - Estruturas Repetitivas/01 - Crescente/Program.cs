using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite dois números:");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        while (x != y)
        {
            if (x < y)
            {
                Console.WriteLine("CRESCENTE!");
            }
            else
            {
                Console.WriteLine("DECRESCENTE!");
            }

            Console.WriteLine("Digite outros dois números:");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números iguais. Encerrando o programa.");
    }
}