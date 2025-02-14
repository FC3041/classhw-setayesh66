using System;

class Program
{
    static void lefttri(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }

    static void lefttri2(int n, char c)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string(c, i));
        }  
    }

    static void righttri(int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(new string(' ', n-i) + new string('*', i));
        }

    }

    static void Main(string[] args)
    {
        lefttri(20);
        lefttri2(20, '+');
        righttri(20);
    }


}