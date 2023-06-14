using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine ("Digite o valor de X: ");
    double x = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor de Y: ");
    double y = double.Parse(Console.ReadLine());

    double soma = (x + y);

    Console.WriteLine($"SOMA = {soma}");

  }
}