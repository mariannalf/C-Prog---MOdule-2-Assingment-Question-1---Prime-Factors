using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number to find its prime factors:");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine($"Prime factors of {number} are: {PrimeFactors(number)}");
    }

    static string PrimeFactors(int n)
    {
        string result = "";
        int divisor = 2;

        while (n > 1)
        {
            if (n % divisor == 0)
            {
                result += divisor + " ";
                n /= divisor;
            }
            else
            {
                divisor++;
            }
        }

        return result.Trim();
    }
}
