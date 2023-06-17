using System;

class Program
{
    public static void Main(string[] args)
    {
        // Read the name input
        string nome = ReadString("Nome:");
        // Read the hourly rate input
        double valorHora = ReadDouble("Valor por hora:");
        // Read the hours worked input
        double horasTrab = ReadDouble("Horas trabalhadas");

        Console.WriteLine($"\nNome: {nome}\nValor por hora: {valorHora:F2}\nHoras trabalhadas: {horasTrab}\n");

        double remuneracao = horasTrab * valorHora;

        Console.WriteLine($"O pagamento para {nome} deve ser {remuneracao:F2}");
    }

    private static double ReadDouble(string message)
    {
        while(true)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            if(double.TryParse(input, out double result))
            {
                return result;
            }

            Console.WriteLine("Digite um número válido.");
        }
    }

    private static string ReadString(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }
}
