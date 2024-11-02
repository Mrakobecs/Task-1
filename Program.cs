using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите значение M: ");
        int M = int.Parse(Console.ReadLine());

        Console.Write("Введите значение N: ");
        int N = int.Parse(Console.ReadLine());

        if (M > N)
        {
            Console.WriteLine("Ошибка: M должно быть меньше или равно N.");
            return;
        }

        PrintNaturalNumbers(M, N);
    }

    static void PrintNaturalNumbers(int current, int N)
    {
        if (current > N)
        {
            return;
        }

        if (current > 0)
        {
            Console.WriteLine(current);
        }

        PrintNaturalNumbers(current + 1, N);
    }
}

