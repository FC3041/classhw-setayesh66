using System;
using System.Diagnostics;

class Program
{
    static double eulers_constant(double precision)
    {
        double sum=1;
        double a = 1;
        int i=1;
        while (a>=precision)
        {
            a/=i;
            i++;
            sum += a;
        }
        return sum;

    }

    static double power(double a , int b)
    {
        double res = 1;
        for (int i = 0; i < b; i++)
        {
            res *= a;
        }
        return res;
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


    static double exp1(double x, double precision)
    {
        double sum=0;
        int i=0;
        double a=0;

        while (a >= precision)
        {
            a = power(x, i)/factorial(i);
            sum += a;
            i++;
        }
        return sum;
    }

    static double exp2(double x, double precision)
    {
        double sum = 1;
        double a = 1;
        int i = 1;

        while (a>=precision)
        {
            a *= x / i; 
            sum += a;
            i++;
        }
        return sum;
    }

    static double abs(double x)
    {
        return Math.Abs(x);
    }


    static bool near(double x, double y, double closeness = 0.001)
    {
        double max = Math.Max(abs(x), abs(y));
        double k = max * closeness;
        if (abs(x - y) < k)
        {
            return true;
        }
        return false;

    }


    static double sin(double degree, double precision)
    {
        double radian = degree * Math.PI / 180;
        double sum = 0;
        double a = radian;
        int n = 1;

        while (abs(a) >= precision)
        {
            sum += a;
            n += 2;
            a = -a * radian * radian / (n * (n - 1));
        }
        return sum;
    }

    static double square_root(double x, double precision)
    {
        double lowerbound = 0;
        double upperbound = x;
        int iter = 0;

        while (upperbound-lowerbound >precision)
        {
            double mid = (lowerbound+upperbound)/2;
            if (mid*mid < x)
            {
                lowerbound=mid;
            }
            else
            {
                upperbound=mid; 
            }
            iter++;
        }
        Console.WriteLine(iter);
        return (lowerbound + upperbound) / 2;
    }


    static double root2(double x, int n, double precision)
    {
        double lowerBound = 0.0;
        double upperBound = x;
        int iterations = 0;

        while (upperBound - lowerBound > precision)
        {
            double mid = (lowerBound+upperBound)/2;
            double k = power(mid, n);

            if (k<x)
            {
                lowerBound=mid;
            }
            else
            {
                upperBound=mid;
            }
            iterations++;
        }
        return (lowerBound+upperBound)/2;
    }


    static double Ln(double x, double precision)
    {
        double lowerBound=-100;
        double upperBound=100;
       int iter=0; 

        while (upperBound-lowerBound > precision)
        {
            double mid = (lowerBound+upperBound)/2;
            double expmid = exp1(mid, precision); 

            if (expmid < x)
            {
                lowerBound=mid;
            }
            else
            {
                upperBound=mid;
            }
            iter++; 
        }
        return (lowerBound+upperBound)/2;
    }

    static void Main()
    {
        double e0 = eulers_constant(0.0001);
        Console.WriteLine(e0);
        double e1 = exp1(1, 0.000001);
        Console.WriteLine(e1);
        double e2 = exp2(2, 0.0001);
        Console.WriteLine(e2);
        bool ans = near(1, 1.001);
        Console.WriteLine(ans);

        double sin1 = sin(45, 0.0001);
        Console.WriteLine(sin1);
        double sin2 = sin(90, 0.0001);
        Console.WriteLine(sin2);
        double root =  square_root(2, 0.000001);
        Console.WriteLine(root);
        double anss = root2(16, 4, 0.0001);
        Console.WriteLine(anss);
        double ln1 = Ln(10, 0.0001);
        Console.WriteLine(ln1);

//--------------------------------------------------------------
        double x = 1;
        double precision = 0.00001;
        double exp1res = exp1(x, precision);
        double exp2res = exp2(x, precision);
        Console.WriteLine(exp1res);
        Console.WriteLine(exp2res);
        Debug.Assert(near(exp1res, exp2res, 0.0001), "exp1 and exp2 results aren't close enough");
        Console.WriteLine("Assertion passed: exp1 and exp2 results are close enough");
    }
}

