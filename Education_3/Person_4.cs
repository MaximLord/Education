class Person_4
{
    public string Name { get; }
    public int Age { get; }
    public Person_4(string name, int age)
    {
        Name = name; Age = age;
    }
    public Person_4(string name) : this(name, 1) { }
    private Person_4() : this("Tom") { }
}