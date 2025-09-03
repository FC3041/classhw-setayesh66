using System;
using System.ComponentModel.DataAnnotations;

class Program
{
    static double FToC(double f)
    {
        double c = (f-32)*(5/9);
        return Math.Round(c, 2);
    }

    static double CToF(double c)
    {
        double f = (c*(9/5) + 32);
        return Math.Round(f, 2);
    }

    static int factorial(int n)
    {
        int res = 1;
        for (int i = 1; i < n+1; i++)
        {
            res *= i; 
        }
        return res;
    }

    static int power(int a , int b)
    {
        int res = 1;
        for (int i = 0; i < b; i++)
        {
            res *= a;
        }
        return res;
    }




    static void quadradic()
    {
        Console.WriteLine("Enter the value of A:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of B:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the value of C:");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"{root1}, {root2}");
        }
        else if (delta == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"{root}");
        }
        else
        {
            double realroot = -b / (2 * a);
            double imaginaryroot = Math.Sqrt(-delta) / (2 * a);
            Console.WriteLine("this equation doean't have any roots");
        }
    }

    static double average_of_squares0(int n)
    {
        
        double sum=0;

        for (int i = 0; i < n; i++)
        {
            sum += Math.Pow(i,2);
            
        }
        double avr = sum/(n-1);
        return avr;
    }


    static double average_of_squares1(int n)
    {
        
        double sum=0;

        for (int i = 1; i < n+1; i++)
        {
            sum += Math.Pow(i,2);
            
        }
        double avr = sum/(n);
        return avr;
    }



    static void Main()
    {
        double c = FToC(32);
        Console.WriteLine(c);
        double f = CToF(0);
        Console.WriteLine(f);
        int res = factorial(5);
        Console.WriteLine(res);
        int pow = power(2 , 4);
        Console.WriteLine(pow);
        double avr = average_of_squares0(4);
        Console.WriteLine(avr);
        double avr1 = average_of_squares1(4);
        Console.WriteLine(avr1);

        quadradic();  
    }
}

