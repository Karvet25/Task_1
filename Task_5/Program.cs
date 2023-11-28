using System;

class FunctionTable
{
    static void Main()
    {
        Console.Write("Введите начальное значение a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите конечное значение b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите шаг h: ");
        double h = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("\nТаблица значений функции y=f(x):");
        Console.WriteLine(" x\t\t y");

        for (double x = a; x <= b; x += h)
        {
            double y = CalculateFunction(x);
            Console.WriteLine($"{x}\t {y}");
        }
    }

    static double CalculateFunction(double x)
    {
        if (x < 1)
        {
            return Math.Pow(x * x - 1, 2);
        }
        else if (x > 1)
        {
            return Math.Pow(1 + x * x, 2);
        }
        else // x == 1
        {
            return 0;
        }
    }
}
