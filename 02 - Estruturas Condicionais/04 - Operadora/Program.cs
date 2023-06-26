using System;

class Program 
{
  public static void Main (string[] args) 
  
  {
    int minutos, valor;
    double minimo = 50.00;
    
    Console.WriteLine ("Digite a quantidade de minutos:");
    minutos = int.Parse(Console.ReadLine());

    if(minutos <= 100)
    {
      Console.WriteLine("Valor a pagar: {0:F2}", minimo);
    }
    else
    {
      valor = ((minutos - 100) * 2) + 50;
      Console.WriteLine ("VALOR: {0:F2}", valor);
    }
  }
}