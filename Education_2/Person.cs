using System;

namespace Education_2;

class Person : IComparable<Person>
{
    public string Name { get;}
    public int Age { get; set; }
    public Person(string name, int age)
    {
        Name = name; Age = age;
    }
    public int CompareTo(object? o)
    {
        if(o is Person person) return Name.CompareTo(person.Name);
        else throw new ArgumentException("Некорректное значение параметра");
    }
    
    public int CompareTo(Person other)
    {
        if (ReferenceEquals(this, other)) return 0;
        if (ReferenceEquals(null, other)) return 1;
        var nameComparison = string.Compare(Name, other.Name, StringComparison.Ordinal);
        if (nameComparison != 0) return nameComparison;
        return Age.CompareTo(other.Age);
    }
}


    
