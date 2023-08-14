using System;
using System.Collections.Generic;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public double Altura { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Quantas pessoas serao digitadas? ");
        int n = int.Parse(Console.ReadLine());

        List<Pessoa> pessoas = new List<Pessoa>();

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Dados da {i + 1}a pessoa:");
            Pessoa pessoa = new Pessoa();

            Console.Write("Nome: ");
            pessoa.Nome = Console.ReadLine();

            Console.Write("Idade: ");
            pessoa.Idade = int.Parse(Console.ReadLine());

            Console.Write("Altura: ");
            pessoa.Altura = double.Parse(Console.ReadLine());

            pessoas.Add(pessoa);
        }

        double somaAlturas = 0;
        int countMenores16 = 0;

        foreach (Pessoa pessoa in pessoas)
        {
            somaAlturas += pessoa.Altura;
            if (pessoa.Idade < 16)
            {
                countMenores16++;
                Console.WriteLine(pessoa.Nome);
            }
        }

        double alturaMedia = somaAlturas / n;
        double porcentagemMenores16 = (countMenores16 * 100.0) / n;

        Console.WriteLine($"Altura média: {alturaMedia:F2}");
        Console.WriteLine($"Pessoas com menos de 16 anos: {porcentagemMenores16:F1}%");

        Console.ReadLine();
    }
}
