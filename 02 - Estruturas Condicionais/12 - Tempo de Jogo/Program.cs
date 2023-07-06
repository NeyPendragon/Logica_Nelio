using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Digite a hora inicial do jogo:");
        int horaInicial = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a hora final do jogo:");
        int horaFinal = int.Parse(Console.ReadLine());

        int duracao = CalcularDuracaoDoJogo(horaInicial, horaFinal);

        Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
    }

    public static int CalcularDuracaoDoJogo(int horaInicial, int horaFinal)
    {
        int duracao;

        if (horaInicial < horaFinal)
        {
            duracao = horaFinal - horaInicial;
        }
        else
        {
            duracao = 24 - horaInicial + horaFinal;
        }

        return duracao;
    }
}
