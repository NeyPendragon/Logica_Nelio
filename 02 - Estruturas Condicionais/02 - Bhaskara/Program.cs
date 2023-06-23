using System;

class Program {
  public static void Main (string[] args) 
  
  {

    double a = ReadDouble("Valor de A");
    double b = ReadDouble("Valor de B");
    double c = ReadDouble("Valor de C");

    double delta =  (Math.Pow(b,2) -4 * a * c);
    
    double positX = (-b + delta) / 2 * a;
    double negatX = (-b - delta) / 2 * a;

    
    if(delta == 0 )
    {
      positX = -b/(2*a);
      Console.WriteLine("X1 = {0:F4}\nX2 = {1:F4}", positX, negatX);
      
    }
    else if(delta > 0)
    {
      positX = (-b + Math.Sqrt(delta)) / (2 * a);
      negatX = (-b - Math.Sqrt(delta)) / (2 * a);
      Console.WriteLine("X1 = {0:F4}\nX2 = {1:F4}", positX, negatX);
    }
    else
    {
      Console.WriteLine("Problema não possui Raízes reais.");    
    }
    
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