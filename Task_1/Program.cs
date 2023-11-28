using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Калькулятор-калькултором, а БД - топ");
        Console.Write("Введите первое число: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Выберите операцию: ");
        Console.WriteLine("1: Сложение");
        Console.WriteLine("2: Вычитание");
        Console.WriteLine("3: Умножение");
        Console.WriteLine("4: Деление");
        Console.WriteLine("5: Остаток от деления");
        int operation = Convert.ToInt32(Console.ReadLine());

        switch (operation)
        {
            case 1:
                Console.WriteLine($"Результат: {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($"Результат: {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($"Результат: {num1 * num2}");
                break;
            case 4:
                if (num2 != 0)
                {
                    Console.WriteLine($"Результат: {num1 / num2}");
                }
                else
                {
                    Console.WriteLine("Ошибка: Деление на ноль!");
                }
                break;
            case 5:
                Console.WriteLine($"Результат: {num1 % num2}");
                break;
            default:
                Console.WriteLine("Неизвестная операция");
                break;
        }
    }
}