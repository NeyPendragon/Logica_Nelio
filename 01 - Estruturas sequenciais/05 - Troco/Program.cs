using System;

class Program {
  public static void Main (string[] args) {
    
    Console.WriteLine ("Digite o valor do produto: ");
    double valorUnidade = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite quantidade comprada: ");
    double quantidade = double.Parse(Console.ReadLine());
    Console.WriteLine("Digite o valor pago: ");
    double recebido = double.Parse(Console.ReadLine());

    double valorTotal = (valorUnidade * quantidade);
    double troco = recebido - valorTotal;

    Console.WriteLine($"Preço unitário do produto: {valorUnidade:F2}\nQuantidade comprada: {quantidade}\nDinheiro recebido: {recebido:F2}\nTROCO: {troco:F2}");

  }
}