using System;

class Program {
  public static void Main (string[] args) 
  
  {
    Console.WriteLine("Digite a duração em segundos: ");
    int segundos = int.Parse(Console.ReadLine());

    int horas = segundos / 3600;
    segundos = segundos % 3600;

    int minutos = segundos / 60;
    segundos = segundos % 60;

    Console.WriteLine("\n" + horas.ToString("D2") + ":" + 
minutos.ToString("D2") + ":" + segundos.ToString("D2"));
  }
} 