using System;

class Program
{
    static void Main()
    {
        Console.Write("Quantos números você vai digitar? ");
        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("NULO");
            }
            else
            {
                if (numero % 2 == 0)
                {
                    Console.Write("PAR ");
                }
                else
                {
                    Console.Write("IMPAR ");
                }

                if (numero > 0)
                {
                    Console.WriteLine("POSITIVO");
                }
                else
                {
                    Console.WriteLine("NEGATIVO");
                }
            }
        }
    }
}
