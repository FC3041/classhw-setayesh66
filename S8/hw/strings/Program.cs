using System;
using System.Collections.Generic;

public class Program
{
    public static void reverse_whole(string sent, out string rev)
    {
        rev = "";
        for (int i = 0; i < sent.Length; i++)
        {
            rev = rev + sent[sent.Length - i - 1];
        }
    }
    public static string[] split(string str)
    {
        List<string> words = new List<string>();
        string sent1 = "";
        for (int i = 0; i < str.Length; i++)
        {
            if (str[i] == ' ')
            {
                if (!string.IsNullOrEmpty(sent1))
                {
                    words.Add(sent1);
                    sent1 = "";
                }
            }
            else
            {
                sent1 += str[i];
            }
        }

        if (!string.IsNullOrEmpty(sent1))
        {
            words.Add(sent1);
        }
        return words.ToArray();
    }

    public static void reverse_byword(string str, out string res)
    {
        string[] words = split(str); 
        res = "";
        for (int i = words.Length - 1; i >= 0; i--)
        {
            res += words[i] + " ";
        }
        res = res.Trim(); 
    }

    public static void Main(string[] args)
    {
        string sent11 = "this string reversed in whole";
        string revstr;
        reverse_whole(sent11, out revstr);
        Console.WriteLine(revstr);

        string sent22 = "this string reversed word by word";
        string reversedsent;
        reverse_byword(sent22, out reversedsent);
        Console.WriteLine(reversedsent);
    }
}