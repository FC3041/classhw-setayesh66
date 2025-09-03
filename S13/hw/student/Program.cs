

namespace student;

class Program
{
    // public static void printperson(Iperson[] ps)
    // {
    //     foreach (var p in ps)
    //     {
    //         Console.WriteLine(p.fullname);
    //     }
    // }

    public static void printperson(Iperson<int>[] ps)
    {
        foreach (var p in ps)
        {
            Console.WriteLine(p);
        }
    }

    
    public static void Main(string[] args)
    {
        Student[] stds = new Student[]
        {
            new Student()
            {
                firstname = "Stayesh",
                lastname = "eszd",
                gpa = 13.5,
                id = 196
            },

            new Student()
            {
                firstname = "Najme",
                lastname = "slmp",
                gpa = 14,
                id = 927
            },

            new Student()
            {
                firstname = "Parnia",
                lastname = "Aln",
                gpa = 15.25,
                id = 465
            },

        };

        printperson(stds);
        // Array.Sort(stds);
        // mySort1(stds);
        // mySort2(stds, new firstnameComparer());
        mySort2(stds, personComparers.firstnameComparer);
        System.Console.WriteLine("------------------");
        printperson(stds);
        mySort2(stds, personComparers.lastnameComparer);
        System.Console.WriteLine("------------------");
        printperson(stds);
        mySort2(stds, personComparers.idComparer);
        System.Console.WriteLine("------------------");
        printperson(stds);
    }

    // public static void mySort1(Iperson<int>[] persons)
    // {
    //     for (int i = 0; i <persons.Length; i++)
    //     {
    //         for (int j = i+1; j < persons.Length; j++)
    //         {
    //             if (persons[i].CompareTo(persons[j])>0)
    //             {
    //                 swap(persons, i, j);
    //             }
    //         }
    //     }
    // }

    public static void mySort2(Iperson<int>[] persons, IComparer<Iperson<int>> cmp)
    {
        for (int i = 0; i <persons.Length; i++)
        {
            for (int j = i+1; j < persons.Length; j++)
            {
                if (cmp.Compare(persons[i], persons[j])>0)
                {
                    swap(persons, i, j);
                }
            }
        }
    }


    private static void swap<T>(T[] items, int i, int j)
    {
        T temp = items[i];
        items[i] = items[j];
        items[j] = temp;
    }
}