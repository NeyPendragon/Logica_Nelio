using System;

namespace Experiencias
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos casos de teste serao digitados? ");
            int n = int.Parse(Console.ReadLine());

            int totalCobaias = 0;
            int totalCoelhos = 0;
            int totalRatos = 0;
            int totalSapos = 0;

            for (int i = 0; i < n; i++)
            {
                int quantidade;
                char tipoCobaia;

                while (true)
                {
                    Console.Write("Quantidade de cobaias: ");
                    string inputQuantidade = Console.ReadLine();

                    if (int.TryParse(inputQuantidade, out quantidade))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido! Digite novamente.");
                    }
                }

                while (true)
                {
                    Console.Write("Tipo de cobaia (R - Rato, S - Sapo, C - Coelho): ");
                    string inputTipoCobaia = Console.ReadLine();

                    if (!string.IsNullOrEmpty(inputTipoCobaia))
                    {
                        tipoCobaia = char.ToUpper(inputTipoCobaia[0]);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Valor inválido! Digite novamente.");
                    }
                }

                totalCobaias += quantidade;

                switch (tipoCobaia)
                {
                    case 'R':
                        totalRatos += quantidade;
                        break;
                    case 'S':
                        totalSapos += quantidade;
                        break;
                    case 'C':
                        totalCoelhos += quantidade;
                        break;
                }
            }

            Console.WriteLine("\nRELATORIO FINAL:");
            Console.WriteLine($"Total: {totalCobaias} cobaias");
            Console.WriteLine($"Total de coelhos: {totalCoelhos}");
            Console.WriteLine($"Total de ratos: {totalRatos}");
            Console.WriteLine($"Total de sapos: {totalSapos}");
            Console.WriteLine($"Percentual de coelhos: {((double)totalCoelhos / totalCobaias * 100):F2}");
            Console.WriteLine($"Percentual de ratos: {((double)totalRatos / totalCobaias * 100):F2}");
            Console.WriteLine($"Percentual de sapos: {((double)totalSapos / totalCobaias * 100):F2}");
        }
    }
}
