using System;


class Program
{
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

        static void MoreAsciiiArt(int n)
    {
        for (int i = 0; i < n+1; i++)
        {
            if (i%2==0)
            {
                Console.WriteLine(new string('*', i));
            }
            else
            {
                Console.WriteLine(new string('%', i));
            }
        }
    }

    static void print_cone(int b)
    {
        Console.WriteLine(new string(' ',(b-1)/2) + '^');
        for (int i = 1; i < (b+1)/2+1; i++)
        {
            Console.WriteLine(new string(' ',(((b-1)/2)-i)) + new string('/', i) + '|' + new string('\\', i));
        }
    }

    static void print_cone_odd(int b)
    {
        Console.WriteLine(new string(' ',(b-1)/2) + '^');
        for (int i = 1; i < (b+1)/2+1; i++)
        {
            if (i%2==1)
            {
                Console.WriteLine(new string(' ',(((b-1)/2)-i)) + new string('/', i) + '|' + new string('\\', i));
            }
        }
    }


    static string GetMonthName(int monthNumber)
    {
        if (monthNumber == 1) 
        return "Jan";
        if (monthNumber == 2) 
        return "Feb";
        if (monthNumber == 3) 
        return "Mar";
        if (monthNumber == 4) 
        return "Apr";
        if (monthNumber == 5) 
        return "May";
        if (monthNumber == 6) 
        return "Jun";
        if (monthNumber == 7) 
        return "Jul";
        if (monthNumber == 8) 
        return "Aug";
        if (monthNumber == 9) 
        return "Sep";
        if (monthNumber == 10) 
        return "Oct";
        if (monthNumber == 11) 
        return "Nov";
        if (monthNumber == 12) 
        return "Dec";
        else
        return "none";
    }


    static void compute_change(int cents)
    {
        if (cents >= 100)
        {
            return;
        }

        int quarters = cents / 25;
        cents = cents % 25;

        int dimes = cents / 10;
        cents = cents % 10;

        int nickels = cents / 5;
        cents = cents % 5;

        int pennies = cents;

        Console.WriteLine(quarters);
        Console.WriteLine(dimes);
        Console.WriteLine(nickels);
        Console.WriteLine(pennies);
    }


    static void Pythagorean()
    {
        for (int a = 1; a < 100; a++)
        {
            for (int b = a + 1; b < 100; b++)
            {
                for (int c = b + 1; c < 100; c++)
                {
                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine($"{a}, {b}, {c}");
                    }
                }
            }
        }
    }


    static void Main()
    {
        bool res = is_leap_year(1792);
        Console.WriteLine(res);
        MoreAsciiiArt(4);
        print_cone(7);
        print_cone_odd(9);
        Console.WriteLine(GetMonthName(10));
        compute_change(56);
        Pythagorean();
    }

}