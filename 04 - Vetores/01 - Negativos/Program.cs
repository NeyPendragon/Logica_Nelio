using System;

namespace NumerosNegativos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int[] numeros = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("NUMEROS NEGATIVOS:");
            foreach (int numero in numeros)
            {
                if (numero < 0)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
}
