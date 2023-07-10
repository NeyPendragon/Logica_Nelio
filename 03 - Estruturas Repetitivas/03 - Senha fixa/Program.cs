using System;

class Program
{
    static void Main()
    {
        int senhaCorreta = 2002;
        
        Console.WriteLine("Digite a senha:");
        
        while (true)
        {
            int senhaDigitada = int.Parse(Console.ReadLine());
            
            if (senhaDigitada == senhaCorreta)
            {
                Console.WriteLine("Acesso permitido!");
                break;
            }
            
            Console.WriteLine("Senha inválida! Tente novamente:");
        }
    }
}
