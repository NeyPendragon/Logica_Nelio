using System;

class Program 
{
  public static void Main (string[] args) 
  
  {
    double valor;

    Console.WriteLine ("Digite a medida da glicose: ");
    valor = double.Parse(Console.ReadLine());

    if(valor < 100)
    {
      Console.WriteLine("Classificação: NORMAL");
    }
    else if(valor > 140)
    {
      Console.WriteLine("Classificação: DIABETES");
    }
    else
    {
      Console.WriteLine("Classificação: ELEVADO");
    }
  }
}