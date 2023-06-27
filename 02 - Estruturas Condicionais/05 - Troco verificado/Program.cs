using System;

class Program 
{
  public static void Main (string[] args) 
  
  {    

    int quantidade;
    double preco, recebido, troco, total;
    
    Console.WriteLine ("Preço unitário do produto");
    preco = double.Parse(Console.ReadLine());
    Console.WriteLine("Quantidade comprada: ");
    quantidade = int.Parse(Console.ReadLine());
    Console.WriteLine("Dinheiro recebido: ");
    recebido = double.Parse(Console.ReadLine());

    total = preco * quantidade;
    
    if (recebido < total)
    {
      troco = (total - recebido);
      Console.WriteLine("DINHEIRO INSUFICIENTE. FALTAM {0:F2} Reais", troco);
    }
    else
    {
      troco = (recebido - total);
      Console.WriteLine("Troco: {0:F2}", troco);
    }
  }
}