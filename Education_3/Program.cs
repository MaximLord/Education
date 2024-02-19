// See https://aka.ms/new-console-template for more information

using System.Reflection;
using System.Threading;     
using static System.Console;

internal partial class Program
{
    public static void Main(string[] args)
    {



        //Многопоточность (информация о текущем потоке)
        // получаем текущий поток
        // Thread currentThread = Thread.CurrentThread;
        //
        //     //получаем имя потока
        // Console.WriteLine($"Имя потока: {currentThread.Name}");
        // currentThread.Name = "Метод Main";
        // Console.WriteLine($"Имя потока: {currentThread.Name}");
        //
        // Console.WriteLine($"Запущен ли поток: {currentThread.IsAlive}");
        // Console.WriteLine($"Id потока: {currentThread.ManagedThreadId}");
        // Console.WriteLine($"Приоритет потока: {currentThread.Priority}");
        // Console.WriteLine($"Статус потока: {currentThread.ThreadState}");
        //


        // создаем новый поток
        // Thread myThread = new Thread(Print);
        // // запускаем поток myThread
        // myThread.Start();
        //
        // // действия, выполняемые в главном потоке
        // for (int i = 0; i < 5; i++)
        // {
        //     Console.WriteLine($"Главный поток: {i}");
        //     Thread.Sleep(300);
        // }
        //
        // // действия, выполняемые во втором потокке
        // void Print()
        // {
        //     for (int i = 0; i < 5; i++)
        //     {
        //         Console.WriteLine($"Второй поток: {i}");
        //         Thread.Sleep(400);
        //     }
        // }


        // Task task1 = new Task(() => Console.WriteLine("Task1 is executed"));
        // task1.Start();
        //
        // Task task2 = Task.Factory.StartNew(() => Console.WriteLine("Task2 is executed"));
        //
        // Task task3 = Task.Run(() => Console.WriteLine("Task3 is executed"));
        //
        // task1.Wait();   // ожидаем завершения задачи task1
        // task2.Wait();   // ожидаем завершения задачи task2
        // task3.Wait();   // ожидаем завершения задачи task3



        // Console.WriteLine("Main Starts");
        // // создаем задачу
        // Task task1 = new Task(() =>
        // {
        //     Console.WriteLine("Task Starts");
        //     Thread.Sleep(1000);     // задержка на 1 секунду - имитация долгой работы
        //     Console.WriteLine("Task Ends");
        // });
        // task1.Start();  // запускаем задачу
        // task1.Wait();   // ожидаем выполнения задачи
        // Console.WriteLine("Main Ends");
        //
        // Task task1 = new Task(() =>
        // {
        //     Console.WriteLine($"Id задачи: {Task.CurrentId}");
        // });
        //
        // // задача продолжения - task2 выполняется после task1
        // Task task2 = task1.ContinueWith(PrintTask);
        //
        // task1.Start();
        //
        // // ждем окончания второй задачи
        // task2.Wait();
        // Console.WriteLine("Конец метода Main");
        //
        //
        // void PrintTask(Task t)
        // {
        //     Console.WriteLine($"Id задачи: {Task.CurrentId}");
        //     Console.WriteLine($"Id предыдущей задачи: {t.Id}");
        //     Thread.Sleep(3000);
        // }


        // CancellationTokenSource cancelTokenSource = new CancellationTokenSource();
        // CancellationToken token = cancelTokenSource.Token;
        //
        // // задача вычисляет квадраты чисел
        // Task task = new Task(() =>
        // {
        //     for (int i = 1; i < 10; i++)
        //     {
        //         if (token.IsCancellationRequested)  // проверяем наличие сигнала отмены задачи
        //         {
        //             Console.WriteLine("Операция прервана");
        //             return;     //  выходим из метода и тем самым завершаем задачу
        //         }
        //         Console.WriteLine($"Квадрат числа {i} равен {i * i}");
        //         Thread.Sleep(200);
        //     }
        // }, token);
        // task.Start();
        //
        // Thread.Sleep(1000);
        // // после задержки по времени отменяем выполнение задачи
        // cancelTokenSource.Cancel();
        // // ожидаем завершения задачи
        // Thread.Sleep(1000);
        // //  проверяем статус задачи
        // Console.WriteLine($"Task Status: {task.Status}");
        // cancelTokenSource.Dispose(); // освобождаем ресурсы


        // await PrintAsync();   // вызов асинхронного метода
        // Console.WriteLine("Некоторые действия в методе Main");
        //
        //
        // void Print()
        // {
        //     Thread.Sleep(3000);     // имитация продолжительной работы
        //     Console.WriteLine("Hello METANIT.COM");
        // }
        //
        // // определение асинхронного метода
        // async Task PrintAsync()
        // {
        //     Console.WriteLine("Начало метода PrintAsync"); // выполняется синхронно
        //     await Task.Run(() => Print());                // выполняется асинхронно
        //     Console.WriteLine("Конец метода PrintAsync");
        // }


        // // асинхронное лямбда-выражение
        // Func<string, Task> printer = async (message) =>
        // {
        //     await Task.Delay(1000);
        //     Console.WriteLine(message);
        // };
        //
        // await printer("Hello World");
        // await printer("Hello METANIT.COM");


        // var square5 = SquareAsync(5);
        // var square6 = SquareAsync(6);
        //
        // Console.WriteLine("Остальные действия в методе Main");
        //
        // int n1 = await square5;
        // int n2 = await square6;
        // Console.WriteLine($"n1={n1}  n2={n2}"); // n1=25  n2=36
        //
        // async Task<int> SquareAsync(int n)
        // {
        //     await Task.Delay(0);
        //     var result = n * n;
        //     Console.WriteLine($"Квадрат числа {n} равен {result}");
        //     return result;
        // }


        // var task = PrintAsync("Hi");
        // try
        // {
        //     await task;
        // }
        // catch
        // {
        //     Console.WriteLine(task.Exception?.InnerException?.Message); // Invalid string length: 2
        //     Console.WriteLine($"IsFaulted: {task.IsFaulted}");  // IsFaulted: True
        //     Console.WriteLine($"Status: {task.Status}");        // Status: Faulted
        // }
        //
        // async Task PrintAsync(string message)
        // {
        //     // если длина строки меньше 3 символов, генерируем исключение
        //     if (message.Length < 3)
        //         throw new ArgumentException($"Invalid string length: {message.Length}");
        //     await Task.Delay(1000);     // имитация продолжительной операции
        //     Console.WriteLine(message);
        // }


        // string[] people = { "Tom", "Bob", "Sam", "Tim", "Tomas", "Bill" };
        //
        // // создаем новый список для результатов
        // var selectedPeople = new List<string>();
        // // проходим по массиву
        // foreach (string person in people)
        // {
        //     // если строка начинается на букву T, добавляем в список
        //     if (person.ToUpper().StartsWith("T"))
        //         selectedPeople.Add(person);
        // }
        // // сортируем список
        // selectedPeople.Sort();
        //
        // foreach (string person in selectedPeople)
        //     Console.WriteLine(person);

        // CancellationTokenSource cts = new CancellationTokenSource();
        // // запускаем дополнительную задачу, в которой через 400 миллисек. прерываем операцию
        // new Task(() =>
        // {
        //     Thread.Sleep(400);
        //     cts.Cancel();
        // }).Start();
        //
        // try
        // {
        //     int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, };
        //
        //     var squares = from n in numbers.AsParallel().WithCancellation(cts.Token)
        //         select Square(n);
        //
        //     foreach (var n in squares)
        //         Console.WriteLine(n);
        // }
        // catch (OperationCanceledException)
        // {
        //     Console.WriteLine("Операция была прервана");
        // }
        // catch (AggregateException ex)
        // {
        //     if (ex.InnerExceptions != null)
        //     {
        //         foreach (Exception e in ex.InnerExceptions)
        //             Console.WriteLine(e.Message);
        //     }
        // }
        // finally
        // {
        //     cts.Dispose();
        // }
        // int Square(int n)
        // {
        //     var result = n * n;
        //     Console.WriteLine($"Квадрат числа {n} равен {result}");
        //     Thread.Sleep(1000); // имитация долгого вычисления
        //     return result;
        // }


        //Person_2.cs
        // Type myType = typeof(Person_2);
        //
        // Console.WriteLine("Реализованные интерфейсы:");
        // foreach (Type i in myType.GetInterfaces())
        // {
        //     Console.WriteLine(i.Name);
        // }


        //Person_3.cs
        // Type myType = typeof(Person_3);
        //
        // foreach (MemberInfo member in myType.GetMembers(BindingFlags.DeclaredOnly
        //                                                 | BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
        // {
        //     Console.WriteLine($"{member.DeclaringType} {member.MemberType} {member.Name}");
        // }


        // //Printer.cs
        // Type myType = typeof(Printer);
        //
        // Console.WriteLine("Методы:");
        // foreach (MethodInfo method in myType.GetMethods())
        // {
        //     string modificator = "";
        //
        //     // если метод статический
        //     if (method.IsStatic) modificator += "static ";
        //     // если метод виртуальный
        //     if (method.IsVirtual) modificator += "virtual ";
        //
        //     Console.WriteLine($"{modificator}{method.ReturnType.Name} {method.Name} ()");
        // }

        
        //Person_4
        // Type myType = typeof(Person_4);
        //
        // Console.WriteLine("Конструкторы:");
        // foreach (ConstructorInfo ctor in myType.GetConstructors(
        //              BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public))
        // {
        //     string modificator = "";
        //
        //     // получаем модификатор доступа
        //     if (ctor.IsPublic)
        //         modificator += "public";
        //     else if (ctor.IsPrivate)
        //         modificator += "private";
        //     else if (ctor.IsAssembly)
        //         modificator += "internal";
        //     else if (ctor.IsFamily)
        //         modificator += "protected";
        //     else if (ctor.IsFamilyAndAssembly)
        //         modificator += "private protected";
        //     else if (ctor.IsFamilyOrAssembly)
        //         modificator += "protected internal";
        //
        //     Console.Write($"{modificator} {myType.Name}(");
        //     // получаем параметры конструктора
        //     ParameterInfo[] parameters = ctor.GetParameters();
        //     for (int i = 0; i < parameters.Length; i++)
        //     {
        //         var param = parameters[i];
        //         Console.Write($"{param.ParameterType.Name} {param.Name}");
        //         if (i < parameters.Length - 1) Console.Write(", ");
        //     }
        //     Console.WriteLine(")");
        // }
        

        //Person_5
        // Type myType = typeof(Person_5);
        // Person_5 tom = new Person_5("Tom", 37);
        //
        // // получаем свойство Age
        // var ageProp = myType.GetProperty("Age");
        //
        // // получаем значение свойства Age у объекта tom
        // var age = ageProp?.GetValue(tom);
        // Console.WriteLine(age); 
        //
        // // устанавливаем новое значение для свойства Age объекта tom
        // ageProp?.SetValue(tom, 22);
        // tom.Print();   

        
        //Имена и свойства всех дисков на компьютере
        // DriveInfo[] drives = DriveInfo.GetDrives();
        //
        // foreach (DriveInfo drive in drives)
        // {
        //     Console.WriteLine($"Название: {drive.Name}");
        //     Console.WriteLine($"Тип: {drive.DriveType}");
        //     if (drive.IsReady)
        //     {
        //         Console.WriteLine($"Объем диска: {drive.TotalSize}");
        //         Console.WriteLine($"Свободное пространство: {drive.TotalFreeSpace}");
        //         Console.WriteLine($"Метка диска: {drive.VolumeLabel}");
        //     }
        //     Console.WriteLine();
        // }
        
    }
    // public class SomeClass: IDisposable
    // {
    //     private bool disposed = false;
    //
    //     // реализация интерфейса IDisposable.
    //     public void Dispose()
    //     {
    //         // освобождаем неуправляемые ресурсы
    //         Dispose(true);
    //         // подавляем финализацию
    //         GC.SuppressFinalize(this);
    //     }
    //
    //     protected virtual void Dispose(bool disposing)
    //     {
    //         if (disposed) return;
    //         if (disposing)
    //         {
    //             // Освобождаем управляемые ресурсы
    //         }
    //         // освобождаем неуправляемые объекты
    //         disposed = true;
    //     }
    //
    //     // Деструктор
    //     ~SomeClass()
    //     {
    //         Dispose (false);
    //     }
    // }
}

    
