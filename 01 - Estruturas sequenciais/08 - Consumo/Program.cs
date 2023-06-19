using System;

class Program
{
    public static void Main(string[] args)
    {

        double dist = ReadDouble("Distância: ");
        double combGasto = ReadDouble("Combustível Gasto: ");

        double media = dist / combGasto;

        Console.WriteLine($"Distância Percorrida: {dist}");
        Console.WriteLine($"Combustível gasto: {combGasto:F1}");
        Console.WriteLine($"Consumo médio: {media:F3}");
    }
    private static double ReadDouble(String message)

    {
        while (true)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if (double.TryParse(input, out double result))
            {
                return result;
            }

            Console.WriteLine("Digite um número válido.");

        }
    }
}