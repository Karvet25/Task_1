using System;

class NumberPyramid
{
    static void Main()
    {
        Console.Write("Введите количество ступеней: ");
        int levels = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < levels; i++)
        {
            for (int j = levels - i - 1; j >= 0; j--)
            {
                Console.Write(j + " ");
            }
            Console.WriteLine();
        }
    }
}
