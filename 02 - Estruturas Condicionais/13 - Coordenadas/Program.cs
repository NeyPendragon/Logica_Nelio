using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Valor de X: ");
        double x = double.Parse(Console.ReadLine());

        Console.WriteLine("Valor de Y: ");
        double y = double.Parse(Console.ReadLine());

        if (x == 0 && y == 0)
        {
            Console.WriteLine("Origem");
        }
        else if (x == 0)
        {
            Console.WriteLine("Eixo Y");
        }
        else if (y == 0)
        {
            Console.WriteLine("Eixo X");
        }
        else if (x > 0 && y > 0)
        {
            Console.WriteLine("Q1");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("Q2");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("Q3");
        }
        else if (x > 0 && y < 0)
        {
            Console.WriteLine("Q4");
        }
    }
}
