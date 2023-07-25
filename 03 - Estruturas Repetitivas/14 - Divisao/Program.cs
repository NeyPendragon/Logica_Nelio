using System;

namespace Divisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos casos você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.Write("Entre com o numerador: ");
                double numerador = double.Parse(Console.ReadLine());

                Console.Write("Entre com o denominador: ");
                double denominador = double.Parse(Console.ReadLine());

                if (denominador == 0)
                {
                    Console.WriteLine("DIVISAO IMPOSSIVEL");
                }
                else
                {
                    double resultado = numerador / denominador;
                    Console.WriteLine($"DIVISAO = {resultado.ToString("F2")}");
                }
            }
        }
    }
}
