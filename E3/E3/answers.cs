using System.Numerics;

public class Animal
{
    public virtual string MakeSound()
    {
        return "Some generic animal sound";
    }
}

public class Dog : Animal
{
    public override string MakeSound()
    {
        return "Woof";
    }
}

public class MyPointType1
{
    public int X { get; set; }
    public int Y { get; set; }
    
}

public struct MyPointType2
{
    public int X { get; set; }
    public int Y { get; set; }
}


public class Comparer<T> where T : IComparable<T>
{
    public T x { get; set; }
    public T y { get; set; }

    public Comparer(T X, T Y)
    {
        x = X;
        y = Y;
    }
    public T GetLarger()
    {
        if (x.CompareTo(y) > 0)
        {
            return x;
        }
        return y;
    }
    // public T CompareTo(T? other)
    // {
    //     throw new NotImplementedException();
    // }
}

public class Product : IComparable<Product>
{
    public string Name { get; set; }
    public int Price { get; set; }

    // public Product(string name, int price)
    // {
    //     Name = name;
    //     Price = price;
    // }
    public int CompareTo(Product? other)
    {
        return Price.CompareTo(other.Price);
        // throw new NotImplementedException();
    }
}


public class ResourceManager : IDisposable
{
    public bool IsDisposed { get; set; }
    public void Dispose()
    {
        IsDisposed = true;
    }
}


public class Sale
{
    public string Category { get; set; }
    public int Amount { get; set; }

    // public Sale(string category, int amount)
    // {
    //     Category = category;
    //     Amount = amount;
    // }
}

public static class LinqProblems
{
    public static IEnumerable<int> FilterAndDouble(List<int> numbers)
    {
        return numbers.Where(n => n > 5 && n % 2 == 0).Select(n => n * 2);
    }


    public static Dictionary<string, int> GetTotalAmountByCategory(List<Sale> sales)
    {
        return sales.GroupBy(s => s.Category).ToDictionary(g => g.Key, g => g.Sum(s => s.Amount));
    }
}


public class Money : IEquatable<Money>
{
    public int Amount{ get; set; }
    public string Mny{ get; set; }

    public Money(int amount, string mny)
    {
        Amount = amount;
        Mny = mny;
    }

    public static Money operator +(Money x, Money y)
    {
        return new Money(x.Amount + y.Amount, x.Mny);
    }

    public static bool operator ==(Money x, Money y)
    {
        return x.Amount == y.Amount;
    }

    public static bool operator !=(Money x, Money y)
    {
        return x.Amount != y.Amount;
    }
    public bool Equals(Money? other)
    {
        return Amount == other.Amount && Mny == other.Mny;
        // throw new NotImplementedException();
    }
}


public class LambdaProblems
{
    public static Func<string, int> GetStringLengthCalculator() => (str => str.Length);
}


public class DataService
{
    public async Task<string> FetchDataAsync(string str)
    {
        await Task.Delay(1000);
        return $"Data for {str}";
    }
}
