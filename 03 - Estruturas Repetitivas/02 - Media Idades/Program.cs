using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite as idades:");

        var calculadoraMedia = new CalculadoraMedia();

        while (true)
        {
            int idade = int.Parse(Console.ReadLine());

            if (idade < 0)
                break;

            calculadoraMedia.AdicionarIdade(idade);
        }

        double media = calculadoraMedia.CalcularMedia();

        if (media >= 0)
            Console.WriteLine("MEDIA = " + media.ToString("F2"));
        else
            Console.WriteLine("IMPOSSIVEL CALCULAR");
    }
}

class CalculadoraMedia
{
    private int somaIdades;
    private int quantidadeIdades;

    public void AdicionarIdade(int idade)
    {
        somaIdades += idade;
        quantidadeIdades++;
    }

    public double CalcularMedia()
    {
        if (quantidadeIdades == 0)
            return -1;

        return (double)somaIdades / quantidadeIdades;
    }
}
