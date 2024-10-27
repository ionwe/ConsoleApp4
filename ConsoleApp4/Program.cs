using System;

class Program
{
    static void Main()
    {
        int n = 10; // Позиция в последовательности Фибоначчи
        Console.WriteLine($"Фибоначчи({n}) = {Fibonacci(n)}");
    }
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}