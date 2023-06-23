using System.Globalization;

class Program 
{
  public static void Main (string[] args) 
  
    {
        double nota1, nota2, notaFinal;
        CultureInfo CI = CultureInfo.InvariantCulture;

        Console.Write("Digite a primeira nota: ");
        nota1 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);
        Console.Write("Digite a segunda nota: ");
        nota2 = double.Parse(Console.ReadLine().Replace(',', '.'), CI);

        notaFinal = (nota1 + nota2) / 2;

        string situacao = notaFinal < 60.0 ? "REPROVADO" : "";
        Console.WriteLine($"NOTA FINAL: {notaFinal:F1}\n {situacao}");

      static double ReadDouble(String message)
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
}