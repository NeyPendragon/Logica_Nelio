using System;

namespace SequenciaImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor de X: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Números ímpares de 1 até X:");

            for (int i = 1; i <= x; i += 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
