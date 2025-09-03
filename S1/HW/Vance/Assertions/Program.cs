using System;
using System.Diagnostics;

class Program
{
    static int Factorial(int n)
    {
        Debug.Assert(n >= 0, "Precondition: n must be non-negative");

        int result = 1;

        for (int i = 1; i <= n; i++)
        {
            Debug.Assert(result > 0, "Loop Invariant: result must be positive");

            result *= i;
        }
        Debug.Assert(result > 0, "Postcondition: result must be positive");

        return result;
    }


    static bool IsPrime(int n)
    {
        Debug.Assert(n > 1, "Precondition: n must be greater than 1");

        for (int i = 2; i * i <= n; i++)
        {
            if (n % i == 0)
            {
                return false;
            }
        }

        return true;
    }


    static void Main()
    {
        Console.WriteLine(Factorial(5));
        Console.WriteLine(IsPrime(7));  
    }
}
