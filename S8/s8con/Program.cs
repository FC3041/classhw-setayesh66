// using System.ComponentModel;
// using System.ComponentModel.Design.Serialization;



namespace s8con;
// using System;
public class Program
{
    public static void reverse(string s, out string srev)
    {

    }
    public static int add(int a, int b)
    {
        return a+b;
    }

    public void prepend_user(string s, out string  sout)
    {
        sout = "user:"+s;
    }




    static void Main(string[] args)
    {
        int sum =0;
        while (true)
        {
            System.Console.WriteLine("Nums?");
            string s = Console.ReadLine();
            if (string.IsNullOrEmpty(s))
                break;
            
            // sum += int.Parse(s);
            int n;
            if (! int.TryParse(s, out n))
            {
                System.Console.WriteLine("wrong");
                continue;
            }
            string sout;
            prepend_user(sum, out sout);
            sum += n;
            
            
        }

        System.Console.WriteLine(sum);
    }
}
