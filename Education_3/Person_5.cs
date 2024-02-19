class Person_5
{
    public string Name { get; }
    public int Age { get; set; }
    public Person_5(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public void Print() => Console.WriteLine($"{Name} - {Age}");
}