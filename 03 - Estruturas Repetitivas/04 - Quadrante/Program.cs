using System;

class Ponto
{
    public int X { get; }
    public int Y { get; }

    public Ponto(int x, int y)
    {
        X = x;
        Y = y;
    }

    public string ObterQuadrante()
    {
        if (X > 0 && Y > 0)
        {
            return "Q1";
        }
        else if (X < 0 && Y > 0)
        {
            return "Q2";
        }
        else if (X < 0 && Y < 0)
        {
            return "Q3";
        }
        else // única resposta possível: X > 0 && Y < 0
        {
            return "Q4";
        }
    }
}

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Digite os valores das coordenadas X e Y:");
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            if (x == 0 || y == 0)
            {
                break;
            }

            Ponto ponto = new Ponto(x, y);
            string quadrante = ponto.ObterQuadrante();
            Console.WriteLine($"QUADRANTE {quadrante}");
        }
    }
}