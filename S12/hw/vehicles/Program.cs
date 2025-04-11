namespace vehicles;

class Program
{
    static void Main(string[] args)
    {
        Ivehicale[] vehicles = new Ivehicale[]
        {
            new Cars(40, 30, 4, 10),
            new Motors(30, 10, 2, 15),
            new Bikes(25, 10, 1, 20)
        };

        for (int i = 0; i < vehicles.Length; i++)
        {
            Console.WriteLine(vehicles[i].area());
            Console.WriteLine(vehicles[i].capacity());
            Console.WriteLine(vehicles[i].numbers());
            Console.WriteLine("-------------");
        }
    }
}