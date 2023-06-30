using System;

class Program 
{
  public static void Main (string[] args) 
  
  {
    char escala;
    double celsius, farenheit;

    Console.Write("Voce vai digitar a temperatura em qual escala (C / F)? ");
    escala = char.Parse(Console.ReadLine().ToUpper());

    if(escala == 'F')
    {
      Console.Write("Digite a temperatura em Farenheit ");
      farenheit = double.Parse(Console.ReadLine());
      celsius = (5.0 / 9.0) * (farenheit - 32);
      Console.WriteLine("Temperatura equivalente em Celsius: " + celsius.ToString("F2"));
      }

    else
    {
      Console.Write("Digite a temperatura em Celsius ");
      celsius = double.Parse(Console.ReadLine());
      farenheit = celsius * 9.0 / 5.0 + 32;
      Console.WriteLine("Temperatura equivalente em Farenheit: " + farenheit.ToString("F2"));
    }
  }
}