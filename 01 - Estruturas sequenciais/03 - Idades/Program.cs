using System;

class Program
{
    public static void Main(string[] args)
    {
      
        Console.WriteLine("Digite o nome:");
        string usr1 = Console.ReadLine();
        Console.WriteLine($"Digite a idade de {usr1}");
        string idadeUsr1Input = Console.ReadLine();
        Console.WriteLine("Digite o segundo nome:");
        string usr2 = Console.ReadLine();
        Console.WriteLine($"Digite a idade de {usr2}");
        string idadeUsr2Input = Console.ReadLine();

        double idadeUsr1, idadeUsr2;

        if (double.TryParse(idadeUsr1Input, out idadeUsr1) && double.TryParse(idadeUsr2Input, out idadeUsr2))

        {
            Console.WriteLine($"\nDados da primeira pessoa:\nNome: {usr1}\nIdade: {idadeUsr1}\n");
            Console.WriteLine($"Dados da segunda pessoa:\nNome: {usr2}\nIdade: {idadeUsr2}\n");

            double mediaIdade = (idadeUsr1 + idadeUsr2) / 2;
            Console.WriteLine($"A idade média de {usr1} e {usr2} é de {mediaIdade:F2} anos");
        }

        else

        {
            Console.WriteLine("ERRO");
        }
    }
}