using System;

class Program
{
    static int absolute_value(int x)
    {
        return Math.Abs(x);
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

    static bool is_divisible(int a,int b)
    {
        if (a%b==0)
        {
            return true;
        }
        return false;
    }

    static bool is_prime(int n)
    {
        for (int i = 2; i < n; i++)
        {
            if (is_divisible(n,i)==true)
            {
                return false;
            }
        }
        return true;
    }

    static int fibonacci(int n)
    {
        if (n<=2)
        {
            return 1;
        }
        return (fibonacci(n-2)+fibonacci(n-1));
    }

    static int days_in_month(int n)
    {
        int[] days_in_each_month = {31, 31, 31, 31, 31, 31, 30, 30, 30, 30, 30, 29};
        return days_in_each_month[n - 1];
    }

    static bool is_leap_year(int y)
    {
        if (y%400==0)
        {
            return true;
        }

        else if (y%4==0 && y%100!= 0)
        {
            return true;
        }

        else
        {
            return false;
        }
    } 

    static int days_in_month2(int m, int y)
    {
        int[] days_in_each_month = {31, 31, 31, 31, 31, 31, 30, 30, 30, 30, 30, 29};

        if (is_leap_year(y)==true && m == 12)
        {
            return 30;
        }

        return days_in_each_month[m - 1];
    }

    static int days_before_date(int year, int monthnum, int daynum)
    {
        int daysbefore = 0;

        for (int i = 1; i < monthnum; i++)
        {
            daysbefore += days_in_month2(i, year);
        }

        daysbefore += (daynum - 1);
        return daysbefore;
    }


    static int DayOfTheWeek(int year, int monthNumber, int dayNumber)
    {
        DateTime date = new DateTime(year, monthNumber, dayNumber);
        int dayOfWeek = ((int)date.DayOfWeek - 1 + 7) % 7;
        return dayOfWeek;
    }

    static void Main()
    {
        Console.WriteLine(absolute_value(-100));
        Console.WriteLine(factorial(5));
        Console.WriteLine(is_divisible(6,2));
        for (int i = 2; i < 100; i++)
        {
            if (is_prime(i)==true)
            {
                Console.WriteLine(i);
            } 
        }
        for (int i = 1; i < 21; i++)
        {
            Console.WriteLine(fibonacci(i));
        }
        Console.WriteLine(days_in_month(5));
        Console.WriteLine("Year: 1397, "  + "Month: 12, " + "Days: " + days_in_month2(12, 1397));
        Console.WriteLine(days_before_date(2025, 10, 25));
        int day = DayOfTheWeek(2014, 8, 17);
        Console.WriteLine(day);
    }
    
}
