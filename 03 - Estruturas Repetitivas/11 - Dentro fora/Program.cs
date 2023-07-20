using System;

namespace DentroFora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            int dentroIntervalo = 0;
            int foraIntervalo = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                int x = int.Parse(Console.ReadLine());

                if (x >= 10 && x <= 20)
                {
                    dentroIntervalo++;
                }
                else
                {
                    foraIntervalo++;
                }
            }

            Console.WriteLine($"{dentroIntervalo} DENTRO");
            Console.WriteLine($"{foraIntervalo} FORA");
        }
    }
}
