using System;
using System.Collections.Generic;

class Product
{
    public int Code { get; set; }
    public double Price { get; set; }

    public Product(int code, double price)
    {
        Code = code;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Product> products = new List<Product>
        {
            new Product(1, 5.00),
            new Product(2, 3.50),
            new Product(3, 4.80),
            new Product(4, 8.90),
            new Product(5, 7.32)
        };

        Console.Write("Codigo do produto comprado: ");
        int inputCode = int.Parse(Console.ReadLine());

        Console.Write("Quantidade comprada: ");
        int quantity = int.Parse(Console.ReadLine());

        Product selectedProduct = products.Find(p => p.Code == inputCode);

        if (selectedProduct != null)
        {
            double total = selectedProduct.Price * quantity;
            Console.WriteLine($"Valor a pagar: R$ {total:F2}");
        }
        else
        {
            Console.WriteLine("Digite um código válido.");
        }
    }
}
