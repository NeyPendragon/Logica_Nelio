using System;

namespace Fatorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());

            int fatorial = 1;

            for (int i = 1; i <= n; i++)
            {
                fatorial *= i;
            }

            Console.WriteLine($"FATORIAL = {fatorial}");
        }
    }
}
