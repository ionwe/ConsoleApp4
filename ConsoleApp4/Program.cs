using System;

class Program
{
    static void Main()
    {
        int n = 10; // Позиция в последовательности Фибоначчи
        Console.WriteLine($"Фибоначчи({n}) = {Fibonacci(n)}");
        int m = 2, n2 = 3; // Параметры для функции Аккермана
        Console.WriteLine($"Аккерман({m}, {n2}) = {Ackermann(m, n2)}");
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
            return (1 << (n + 3)) - 3; // 2^(n+3) - 3
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}