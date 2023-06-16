class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Digite o valor do raio do circulo:");
    double r = double.Parse(Console.ReadLine());

    double area = Math.Pow(r, 2) * Math.PI;

    Console.WriteLine ($"AREA: {area:F4}");
  }
}