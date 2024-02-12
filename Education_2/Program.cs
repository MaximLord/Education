using System;
using System.Text.RegularExpressions;

namespace Education_2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //Account.cs
            // Account account = new Account(100);
            // Console.WriteLine($"Сумма на счете: {account.Sum}");
            //
            // account.Notify += DisplayMessage;   // Добавляем обработчик для события Notify
            //
            // account.Put(20);    // добавляем на счет 20
            // Console.WriteLine($"Сумма на счете: {account.Sum}");
            //
            // account.Take(70);   // пытаемся снять со счета 70
            // Console.WriteLine($"Сумма на счете: {account.Sum}");
            //
            // account.Take(180);  // пытаемся снять со счета 180
            // Console.WriteLine($"Сумма на счете: {account.Sum}");
            //
            // void DisplayMessage(string message) => Console.WriteLine(message);
            //
            // account.Take(900); // пытаемся снять со счета 900
            // Console.WriteLine($"Сумма на счете: {account.Sum}");
            
            
            //Person.cs
            // var tom = new Person("Tom", 37);
            // var bob = new Person("Bob", 41);
            // var sam = new Person("Sam", 25);
            //
            // Person[] people = { tom, bob, sam};
            // Array.Sort(people);
            //
            // foreach (Person person in people)
            // {
            //     Console.WriteLine($"{person.Name} - {person.Age}");
            // }
            
            
            
            //State.cs
            // State aragon = new State { Area = 23, Population = 2 };
            // State kastilia = new State { Area = 41, Population = 5 };
            // State spain = aragon + kastilia;
            // Console.WriteLine(spain.Population);    // 7
            // if(aragon > kastilia)
            // {
            //     Console.WriteLine("Арагон больше Кастилии");
            // }
            // else
            // {
            //     Console.WriteLine("Арагон меньше Кастилии");
            // }
            
            
            //Bread.cs
            // Bread bread = new Bread { Weight = 80 };
            // Butter butter = new Butter { Weight = 20 };
            // Sandwich sandwich = bread + butter;
            // Console.WriteLine(sandwich.Weight);  // 100
            
            
            //Timer.cs
            // Counter counter1 = new Counter { Seconds = 115 };
            //
            // Timer timer = counter1;
            // Console.WriteLine($"{timer.Hours}:{timer.Minutes}:{timer.Seconds}"); // 0:1:55
            //
            // Counter counter2 = (Counter)timer;
            // Console.WriteLine(counter2.Seconds);  //115
            
            
            //Clock.cs
            // Clock clock = new Clock { Hours = 15 };
            //
            // int x = (int)clock;
            // Console.WriteLine(x);   // 15
            //
            // Clock clock2 = 13;
            // Console.WriteLine(clock2.Hours);
            // clock2 = 34;
            // Console.WriteLine(clock2.Hours);
            
            
            //Celcius.cs
            // Celcius celcius = new Celcius { Gradus = 25 };
            // Fahrenheit fahrenheit = celcius;
            // Console.WriteLine(fahrenheit.Gradus);
            // celcius = fahrenheit;
            // Console.WriteLine(celcius.Gradus);
            
            
            //Company.cs
            // var microsoft = new Company(new[]
            // {
            //     new Person2("Tom"), new Person2("Bob"), new Person2("Sam"), new Person2("Alice")
            // });
            // // получаем объект из индексатора
            // Person2 firstPerson2 = microsoft[0];
            // Console.WriteLine(firstPerson2.Name);  // Tom
            // // переустанавливаем объект
            // microsoft[0] = new Person2("Mike");
            // Console.WriteLine(microsoft[0].Name);  // Mike
            //
            
            
            //Создание строк в C#
            // string s1 = "hello";
            // string s2 = new String('a', 6); // результатом будет строка "aaaaaa"
            // string s3 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' });
            // string s4 = new String(new char[] { 'w', 'o', 'r', 'l', 'd' }, 1, 3); // orl
            //
            // Console.WriteLine(s1);  // hello
            // Console.WriteLine(s2);  // aaaaaaa
            // Console.WriteLine(s3);  // world
            // Console.WriteLine(s4);  // orl
            
            
            //Объединение строк
            // string s5 = "apple";
            // string s6 = "a day";
            // string s7 = "keeps";
            // string s8 = "a doctor";
            // string s9 = "away";
            // string[] values = new string[] { s5, s6, s7, s8, s9 };
            //
            // string s10 = string.Join(" ", values);
            // Console.WriteLine(s10); // apple a day keeps a doctor away
            
            
            //Проверка на соответствие строки формату
 
            // string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            //                  @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
            // var data = new string[]
            // {
            //     "tom@gmail.com",
            //     "+12345678999",
            //     "bob@yahoo.com",
            //     "+13435465566",
            //     "sam@yandex.ru",
            //     "+43743989393"
            // };
            //
            // Console.WriteLine("Email List");
            // for(int i = 0; i < data.Length; i++)
            // {
            //     if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase))
            //     {
            //         Console.WriteLine(data[i]);
            //     }
            // }
            
            
            //
            
            
        }
    }
}