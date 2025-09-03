interface Iperson<_Type> : IComparable<Iperson<_Type>>
// : IComparable<Iperson<_Type>>
{
    _Type id {get; set;}    
    string firstname {get; set;}
    string lastname {get; set;}
    string fullname {get;}
    double gpa {get; set;}
}

class Student : Iperson<int> 
//, IComparable<Student>
{
    public string firstname {get; set;}
    public string lastname {get; set;}
    public string fullname => firstname + " " + lastname;
    public int id {get; set;}
    public double gpa {get; set;}

    public int CompareTo(Iperson<int> other) => firstname.CompareTo(other.firstname);

/*    public int CompareTo(Student other)
    {
        return this.firstname.CompareTo(other.firstname);

    ya firstname.CompareTo(other.firstname);
    }
     
    //paeeni kholasash 
    public int CompareTo(Student other) => firstname.CompareTo(other.firstname);
*/

    public override string ToString() => $"{fullname}\t{id}"; 
    //vaghti ye shei ro tabdil be string mikonim noe on shei type mishe 
    //baraye taghir in raftar ke masalan fs ln inaro type kone az in syntax estefade mikonim
}

class firstnameComparer : IComparer<Iperson<int>>
{
    public int Compare(Iperson<int> x, Iperson<int> y)
    {
        return x.firstname.CompareTo(y.firstname);
    }
}

class lastnameComparer : IComparer<Iperson<int>>
{
    public int Compare(Iperson<int> x, Iperson<int> y)
    {
        return x.lastname.CompareTo(y.lastname);
    }
}

class idComparer : IComparer<Iperson<int>>
{
    public int Compare(Iperson<int> x, Iperson<int> y)
    {
        return x.id.CompareTo(y.id);
    }
}

class personComparers
{
    public static firstnameComparer firstnameComparer = new firstnameComparer();
    public static lastnameComparer lastnameComparer = new lastnameComparer();
    public static idComparer idComparer = new idComparer();
}
