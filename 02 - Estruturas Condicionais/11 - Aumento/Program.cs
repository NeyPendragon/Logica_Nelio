using System;

class SalaryCalculator
{
    private double salary;

    public SalaryCalculator(double salary)
    {
        this.salary = salary;
    }

    public void CalculateIncrease(out double newSalary, out double increase, out double percentage)
    {
        if (salary <= 1000)
        {
            percentage = 0.2;
        }
        else if (salary <= 3000)
        {
            percentage = 0.15;
        }
        else if (salary <= 8000)
        {
            percentage = 0.1;
        }
        else
        {
            percentage = 0.05;
        }

        increase = salary * percentage;
        newSalary = salary + increase;
    }
}

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite o salario da pessoa: ");
            double salary = double.Parse(Console.ReadLine());

            SalaryCalculator calculator = new SalaryCalculator(salary);
            calculator.CalculateIncrease(out double newSalary, out double increase, out double percentage);

            Console.WriteLine($"Novo salario = R$ {newSalary:F2}");
            Console.WriteLine($"Aumento = R$ {increase:F2}");
            Console.WriteLine($"Porcentagem = {percentage:P0}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor de salário inválido. Certifique-se de digitar um número válido.");
        }
    }
}
