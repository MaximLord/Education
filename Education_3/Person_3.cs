public class Person_3
{
    string name;
    public int Age { get; set; }
    public Person_3(string name, int age)
    {
        this.name = name;
        this.Age = age;
    }
    public void Print() => Console.WriteLine($"Name: {name} Age: {Age}");
}