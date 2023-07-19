using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite dois numeros:");
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int sum = 0;

        int start = Math.Min(x, y);
        int end = Math.Max(x, y);

        for (int i = start + 1; i < end; i++)
        {
            if (i % 2 != 0)
            {
                sum += i;
            }
        }

        Console.WriteLine("SOMA DOS IMPARES = " + sum);
    }
}