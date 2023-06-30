using System;

class Program 
{
  public static void Main (string[] args) 
  
  {
    double dist1, dist2, dist3;
    
    Console.WriteLine ("Digite as tres distâncias: ");
    dist1 = double.Parse(Console.ReadLine());
    Console.Write("");
    dist2 = double.Parse(Console.ReadLine());
    Console.Write("");
    dist3 = double.Parse(Console.ReadLine());

    if((dist3 > dist2) && (dist3 > dist1))
    {
      Console.WriteLine ("MAIOR DISTANCIA = {0:F2}", dist3);
    }
    else if(dist2 > dist1)
    {
      Console.WriteLine("MAIOR DISTANCIA = {0:F2}", dist2);
    }
    else
    {
      Console.WriteLine("MAIOR DISTANCIA = {0:F2}", dist1);
    }
  }
}