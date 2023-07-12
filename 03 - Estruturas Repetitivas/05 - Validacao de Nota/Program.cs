using System;

class ValidadorDeNota
{
    static void Main(string[] args)
    {
        double primeiraNota = 0, segundaNota = 0;
        bool primeiraNotaValida = false, segundaNotaValida = false;

        while (!primeiraNotaValida)
        {
            Console.Write("Digite a primeira nota: ");
            if (double.TryParse(Console.ReadLine(), out primeiraNota))
            {
                if (primeiraNota >= 0 && primeiraNota <= 10)
                {
                    primeiraNotaValida = true;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido! Tente novamente.");
            }
        }

        while (!segundaNotaValida)
        {
            Console.Write("Digite a segunda nota: ");
            if (double.TryParse(Console.ReadLine(), out segundaNota))
            {
                if (segundaNota >= 0 && segundaNota <= 10)
                {
                    segundaNotaValida = true;
                }
                else
                {
                    Console.WriteLine("Valor inválido! Tente novamente.");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido! Tente novamente.");
            }
        }

        double media = (primeiraNota + segundaNota) / 2;
        Console.WriteLine("MEDIA = " + media.ToString("F2"));
    }
}
