using System;

class MaxMinFinder
{
    static void Main(string[] args)
    {
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Введите число {i + 1}:");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        int maxNumber = numbers[0];
        int minNumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxNumber)
            {
                maxNumber = numbers[i];
            }

            if (numbers[i] < minNumber)
            {
                minNumber = numbers[i];
            }
        }

        Console.WriteLine($"Максимальное число: {maxNumber}");
        Console.WriteLine($"Минимальное число: {minNumber}");
    }
}