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

    static void body()
    {
        Console.WriteLine(" +*******+  ");
        Console.WriteLine(" +*******+  ");
        Console.WriteLine(" +*******+  ");
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
        body();
        line();
        body();
        line();
        cone();
    }
}