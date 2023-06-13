using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Base do retângulo: ");
        string baseRetanguloInput = Console.ReadLine();
        Console.WriteLine("Altura do retângulo: ");
        string alturaInput = Console.ReadLine();

        double baseRetangulo, altura;

        if (double.TryParse(baseRetanguloInput, out baseRetangulo) && double.TryParse(alturaInput, out altura))

        {
            double areaFinal = (baseRetangulo * altura);
            Console.WriteLine("AREA = {0:F4}", areaFinal);
            double perimetro = ((baseRetangulo + altura) * 2);
            Console.WriteLine("PERÍMETRO = {0:F4}", perimetro);
            double diagonal = Math.Sqrt(Math.Pow(baseRetangulo, 2) + Math.Pow(altura, 2));
            Console.WriteLine("DIAGONAL = {0:F4}", diagonal);
          
        }

        else
        {
            Console.WriteLine("Erro");
        }
    }
}