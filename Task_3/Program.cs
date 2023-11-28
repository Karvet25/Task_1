using System;

class FunctionCalculator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите значение x:");
        double x = Convert.ToDouble(Console.ReadLine());

        double y = CalculateFunction(x);
        Console.WriteLine($"Значение функции y для x={x} равно {y}");
    }

    static double CalculateFunction(double x)
    {
        if (2 * x - 1 == 0)
        {
            throw new ArgumentException("Знаменатель не может быть равен нулю.");
        }

        return x / Math.Sqrt(2 * x - 1);
    }
}
