using System;

class Program
{
    public static void Main (string[] args)

    {
        int alcool = 0, diesel = 0, gasolina = 0;
        int codigo;

        do 
        {
            Console.WriteLine("Informe um codigo 1 - gasolina, 2 - álcool, 3 - diesel ou 4 para parar: ");
            codigo = int.Parse(Console.ReadLine());
        
                
        switch (codigo)
        {
            case 1:
                gasolina++;
                break;
            case 2:
                alcool++;
                break;
            case 3:
                diesel++;
                break;

            default:
                Console.WriteLine("Código inválido, tente novamente.");
                break;
        }
    } 
        while (codigo != 4);
        
        Console.WriteLine($"Gasolina: {gasolina}\nÁlcool: {alcool}\nDiesel: {diesel}");

    }
    
}

