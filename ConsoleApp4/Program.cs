using System;

class Program
{
    static void Main()
    {
        int number = 12345;
        int reversedNumber = ReverseNumber(number);
        Console.WriteLine("Reversed number: " + reversedNumber);
    }

    static int ReverseNumber(int num)
    {
        if (num < 10)
        {
            return num;
        }

        int lastDigit = num % 10; 
        int remainingDigits = num / 10; 

        return (int)(lastDigit * Math.Pow(10, (int)Math.Log10(remainingDigits) + 1) + ReverseNumber(remainingDigits));
    }
}
