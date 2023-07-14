using System;

public class Program
{
    public static void Main(string[] args)
    {
        int x;

        do
        {
            Console.Write("Digite um número inteiro: ");
            x = int.Parse(Console.ReadLine());

            if (x != 0)
            {
                int sum = CalculateSum(x);
                Console.WriteLine($"SOMA = {sum}");
            }
        }
        while (x != 0);
    }

    public static int CalculateSum(int x)
    {
        int sum = 0;

        if (x % 2 != 0)
        {
            x++; // Increment x to the next even number
        }

        for (int i = 0; i < 5; i++)
        {
            sum += x;
            x += 2;
        }

        return sum;
    }
}
