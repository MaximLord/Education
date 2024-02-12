using System;

class Person2
{
    public string Name { get;}
    public Person2(string name) => Name=name;
}

class Company
{
    Person2[] personal;
    public Company(Person2[] people) => personal = people;
    // индексатор
    public Person2 this[int index]
    {
        get
        {
            // если индекс имеется в массиве
            if (index >= 0 && index < personal.Length)
                return personal[index]; // то возвращаем объект Person по индексу
            else
                throw new ArgumentOutOfRangeException(); // иначе генерируем исключение
        }
        set
        {
            // если индекс есть в массиве
            if (index >= 0 && index < personal.Length)
                personal[index] = value;    // переустанавливаем значение по индексу
        }
    }
}