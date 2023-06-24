using System;

class Program

{
    public static void Main(string[] args)
    {

      int valorX, valorY, valorZ, menor;
      
      Console.WriteLine("Primeiro Valor: ");
      valorX = int.Parse(Console.ReadLine());
      Console.WriteLine("Segundo Valor: ");
      valorY = int.Parse(Console.ReadLine());
      Console.WriteLine("Terceiro Valor: ");
      valorZ = int.Parse(Console.ReadLine());

      if (valorX < valorY && valorX < valorZ)
      {
        menor = valorX;
      }
      
      else if (valorY < valorZ)
      {
        menor = valorY;
      }

      else 
      {
        menor = valorZ;
      }
      Console.WriteLine("MENOR = {0}", menor);
  }
}