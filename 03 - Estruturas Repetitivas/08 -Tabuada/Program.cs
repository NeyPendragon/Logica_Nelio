﻿using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Deseja a tabuada para qual valor? ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            int resultado = n * i;
            Console.WriteLine($"{n} x {i} = {resultado}");
        }
    }
}