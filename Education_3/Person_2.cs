
public class Person_2 : IEater, IMovable
{
    public string Name { get;}
    public Person_2(string name) => Name = name;
    public void Eat() => Console.WriteLine($"{Name} eats");
 
    public void Move()=> Console.WriteLine($"{Name} moves");
}
interface IEater
{
    void Eat();
}
interface IMovable
{
    void Move();
}