using System;

namespace SomaVetor
{
    class Vetor
    {
        private double[] numeros;

        public Vetor(int tamanho)
        {
            numeros = new double[tamanho];
        }

        public void LerNumeros()
        {
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Digite um numero: ");
                numeros[i] = double.Parse(Console.ReadLine());
            }
        }

        public void ImprimirValores()
        {
            Console.Write("VALORES = ");
            foreach (double numero in numeros)
            {
                Console.Write(numero + " ");
            }
            Console.WriteLine();
        }

        public double CalcularSoma()
        {
            double soma = 0;
            foreach (double numero in numeros)
            {
                soma += numero;
            }
            return soma;
        }

        public double CalcularMedia()
        {
            double soma = CalcularSoma();
            return soma / numeros.Length;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos numeros voce vai digitar? ");
            int n = int.Parse(Console.ReadLine());

            Vetor vetor = new Vetor(n);
            vetor.LerNumeros();

            vetor.ImprimirValores();

            double soma = vetor.CalcularSoma();
            Console.WriteLine($"SOMA = {soma:F2}");

            double media = vetor.CalcularMedia();
            Console.WriteLine($"MEDIA = {media:F2}");
        }
    }
}
