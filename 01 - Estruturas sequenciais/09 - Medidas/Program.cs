using System;

class Program
{
    public static void Main(string[] args)

    {
        Double A = ReadDouble("Digite a medida A:");
        Double B = ReadDouble("Digite a medida B:");
        Double C = ReadDouble("Digite a medida C:");

        Console.WriteLine($"Medida {A}\nMedida {B}\nMedida {C}\n");

        Double areaQuadrado = Math.Pow(A, 2);
        Double areaTriangulo = (A * B) / 2;
        Double areaTrapezio = ((B + A) * C) / 2;

        Console.WriteLine($"Área do Quadrado: {areaQuadrado:F4}\nÁrea do Triângulo: {areaTriangulo:F4}\nÁrea do Trapézio: {areaTrapezio:F4}");
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