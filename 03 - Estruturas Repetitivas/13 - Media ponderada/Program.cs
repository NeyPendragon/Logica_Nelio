using System;

namespace MediaPonderada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos casos você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Digite três números: ");
                double num1 = double.Parse(Console.ReadLine());
                double num2 = double.Parse(Console.ReadLine());
                double num3 = double.Parse(Console.ReadLine());

                double mediaPonderada = (num1 * 2 + num2 * 3 + num3 * 5) / 10;

                Console.WriteLine($"MEDIA = {mediaPonderada.ToString("F1")}");
            }
        }
    }
}
