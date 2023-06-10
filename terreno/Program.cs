using System;

class Program 
{
  public static void Main (string[] args) 
  
  {
    //Declarar das variáveis
    int num1, num2;

    //Pedir os nmros da primeira vez, com primeira frase
    Console.WriteLine ("Digite dois numeros: ");
    //Verificar se é int
    while(!int.TryParse(Console.ReadLine(), out num1))
    {
    //Caso não seja int, executar:
      Console.WriteLine("Digite um número válido");
    }
    while(!int.TryParse(Console.ReadLine(), out num2))
    {
      Console.WriteLine ("Digite um número Válido");
    }

    //Verificados os nmros, ver se são iguais, se forem, encerra
    while( num1 != num2 )
    {
      //Não sendo iguais, verificar se são < ou >
      if (num1 < num2 )
      {
        //Apontar se a ordem dos nmros é crescente ou decrescente.
        Console.WriteLine("CRESCENTE!");
      }
      else
      {
      Console.WriteLine("DECRESCENTE!");
      }
      //Recebe os nmros e repete.
      Console.WriteLine ("Digite outros dois numeros: ");
      while(!int.TryParse(Console.ReadLine(), out num1))
      {
        Console.WriteLine("Digite um número válido");
      }
      while(!int.TryParse(Console.ReadLine(), out num2))
      {
        Console.WriteLine ("Digite um número Válido");
      }
    }
  }  
}