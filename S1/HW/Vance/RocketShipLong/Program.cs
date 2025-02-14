using System;

class Program
{

    static void cone()
    {
        Console.WriteLine("     ^      ");
        Console.WriteLine("    /|\\     ");
        Console.WriteLine("   //|\\\\    ");
        Console.WriteLine("  ///|\\\\\\   ");  
    }

    static void bodyline()
    {
        Console.WriteLine(" +*******+  "); 
    }

    static void line()
    {
        Console.WriteLine(" +-------+  ");  
    }
    static void Main(string[] args)
    {
        cone();
        line();
        for (int i = 0; i < 4; i++)
        {
            bodyline();
        }
        line();
        for (int i = 0; i < 4; i++)
        {
            bodyline();
        }
        line();
        cone();
    }
}