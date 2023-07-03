using System;

class Program 
{
    static void Main(string[] args)
    {
        int firstNumber = GetUserInput("Digite o primeiro número inteiro:");
        int secondNumber = GetUserInput("Digite o segundo número inteiro:");

        if (AreMultiples(firstNumber, secondNumber))
        {
            Console.WriteLine("São múltiplos.");
        }
        else 
        {
            Console.WriteLine("Não são múltiplos.");
        }
    }

    static int GetUserInput(string message)
    {
        Console.WriteLine(message);
        int number;
        while (!int.TryParse(Console.ReadLine(), out number))
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido:");
        }
        return number;
    }

    static bool AreMultiples(int num1, int num2)
    {
        return num1 % num2 == 0 || num2 % num1 == 0;
    }
}