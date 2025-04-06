public interface Ivehicale
{
    public double area();
    public int capacity();
    public int numbers();
}

class Cars:Ivehicale
{
    public double l;
    public double w;
    public int cap;
    public int nums;
    public Cars(double ll, double ww, int capp, int numss)
    {
        l = ll;
        w = ww;
        cap = capp;
        nums = numss;
    }
    public double area()
    {
        return l*w;
    }
    
    public int capacity()
    {
        return cap;
    }

        public int numbers()
    {
        return nums;
    }
}


class Motors:Ivehicale
{
    public double l;
    public double w;
    public int cap;
    public int nums;
    public Motors(double ll, double ww, int capp, int numss)
    {
        l = ll;
        w = ww;
        cap = capp;
        nums = numss;
    }
    public double area()
    {
        return l*w;
    }
    
    public int capacity()
    {
        return cap;
    }

        public int numbers()
    {
        return nums;
    }
}

class Bikes:Ivehicale
{
    public double l;
    public double w;
    public int cap;
    public int nums;
    public Bikes(double ll, double ww, int capp, int numss)
    {
        l = ll;
        w = ww;
        cap = capp;
        nums = numss;
    }
    public double area()
    {
        return l*w;
    }
    
    public int capacity()
    {
        return cap;
    }

        public int numbers()
    {
        return nums;
    }
}