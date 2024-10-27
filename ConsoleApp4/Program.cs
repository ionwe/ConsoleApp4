using System;

class Program
{
    static void Main()
    {
        int n = 10; // Позиция в последовательности Фибоначчи
        Console.WriteLine($"Фибоначчи({n}) = {Fibonacci(n)}");

        int m = 2, n2 = 3; // Параметры для функции Аккермана
        Console.WriteLine($"Аккерман({m}, {n2}) = {Ackermann(m, n2)}");

        int[,] array = {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };
        int target = 7;
        var index = Search2(array, target);
        if (index.HasValue) // Проверяем, есть ли значение в кортежах
        {
            Console.WriteLine($"Число {target} найдено на индексе: [{index.Value.Item1}, {index.Value.Item2}]");
        }
        else
        {
            Console.WriteLine($"Число {target} не найдено в массиве.");
        }
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }

    static int Ackermann(int m, int n)
    {
        if (m == 0)
            return n + 1;
        if (m == 1)
            return n + 2;
        if (m == 2)
            return 2 * n + 3;
        if (m == 3)
            return (1 << (n + 3)) - 3;
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }

    static (int, int)? Search2(int[,] array, int target)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[i, j] == target)
                {
                    return (i, j); // Возвращаем индексы найденного элемента
                }
            }
        }
        return null; // Если элемент не найден, возвращаем null
    }
}
