// See https://aka.ms/new-console-template for more information


// try catch finally


// try
// {
//     int x = 5;
//     int y = x / 0;
//     Console.WriteLine($"Result: {y}");
// }
// catch (Exception ex)
// {
//     Console.WriteLine($"Exception: {ex.Message}");
//     Console.WriteLine($"Method: {ex.TargetSite}");
//     Console.WriteLine($"StackTraccing: {ex.StackTrace}");
// }
//
// Console.Read();

// try
// {
//   try
//   {
//     Console.WriteLine("Enter something");
//     string message = Console.ReadLine();
//     if (message.Length > 8)
//     {
//       throw new Exception("The message is too long");
//     }
//   }
//   catch
//   {
//     Console.WriteLine($"error occured");
//     throw;
//   }
// }
// catch (Exception e)
// {
//   Console.WriteLine($"error occured: {e.Message}");
// }


// var result = Console.ReadLine();
// if (int.TryParse(result, out int resultInt))
// {
//     Console.WriteLine(resultInt);
// }
// else
// {
//     Console.WriteLine("Invalid input");
// }


// Сумма двух чисел из строки
//
// Условие:
// Создай метод SumStrings(string a, string b)
// Если хотя бы одна строка не преобразуется в число — выведи:
//
//     “Ошибка ввода числа”
//
// В finally напечатай:
//
//     “Сумма завершена.”
// void SumStrings(string a, string b)
// {
//
//    var result=Convert.ToInt32(a)+Convert.ToInt32(b);
//    Console.WriteLine(result);
// }
// try
// {
//     SumStrings("12sss22", "10");
// }
// catch (Exception e)
// {
//     Console.WriteLine("Incorrect input");
// }
// finally
// {
//     Console.WriteLine("End of program");
// }



// Проверка логина
//
// Условие:
// Метод Login(string username)
// Если строка пуста — выбрось ArgumentNullException.
//     Если длина < 4 — выбрось Exception с сообщением: “Слишком короткий логин”
// using System.Globalization;
// using System.Xml;
// void Login(string username)
// {
//     try
//     {
//         try
//         {
//             if (username.Length==0)
//             {
//                 throw new ArgumentException();
//
//             }
//             else if (username.Length<4)
//             {
//                Console.WriteLine("Username is too short");
//             }
//         }
//         
//         catch
//         {
//             Console.WriteLine("Exception occured");
//             throw;
//         }
//     }
//     catch (Exception e)
//     {
//         Console.WriteLine(e.Message);
//     }
// }
// Login("");


// Свой throw
//
//     Условие:
// Если число меньше 0, выбрось исключение ArgumentException с сообщением:
//
//     “Число не может быть отрицательным!”


// try
// {
//     try
//     {
//         int num = Convert.ToInt32(Console.ReadLine());
//         if (num < 0)
//         {
//             throw new ArgumentException("Negative number");
//         }
//
//         else
//         {
//             Console.WriteLine(num);
//         }
//
//     }
//     catch
//     {
//         Console.WriteLine("Exception occured");
//         throw;
//     }
// }
// catch(Exception ex)
// {
//     Console.WriteLine(ex.Message);
// }
    
    

// Чтение из массива
//
// Условие:
// Напиши метод ReadElement(int[] array, int index)
// Если индекс вне границ массива — перехвати IndexOutOfRangeException
// и выведи:
//
//     “Элемент с таким индексом не найден.”
//
// В finally выведи:
//
//     “Завершено чтение элемента.”

// void ReadElement(int[] array, int index)
// {
//     try
//     {
//         try
//         {
//
//             if (index >= array.Length)
//             {
//                 throw new IndexOutOfRangeException("Index is out of range.");
//             }
//
//
//             else
//             {
//                 Console.WriteLine(array[index]);
//             }
//
//         }
//         catch
//         {
//             Console.WriteLine("Exception occured");
//             throw;
//         }
//     }
//     catch (Exception ex)
//     {
//         Console.WriteLine(ex.Message);
//     }
//     finally
//     {
//         Console.WriteLine("End of file");
//     }
//
// }
// int[] array=new int[10];
// ReadElement(array,2);



// Проверка пароля
//
// Условие:
// Метод CheckPassword(string password)
//     • Если password null или пустой — выбрось ArgumentNullException
//     • Если длина меньше 8 — выбрось Exception("Слишком короткий пароль")
//     • Если всё ок — напечатай: “Пароль принят”
//
// В finally — “Проверка завершена

// void CheckPassword(string? password)
// {
//     try
//     {
//          try
//          {
//
//              if (password.Length==0)
//              {
//                  throw new ArgumentNullException();
//              }
//              
//              else if (password.Length < 8)
//              {
//                  throw new Exception("Too short password");
//              }
//              else
//              {
//                  Console.WriteLine("Everithing is ok");
//              }
//
//          }
//          catch
//          {
//              Console.WriteLine("Exception occured");
//              throw;
//          }
//     }
//     catch (Exception ex)
//     {
//          Console.WriteLine(ex.Message);
//     }
//     finally
//     {
//          Console.WriteLine("End of file");
//     }
//     
// }
// CheckPassword("");

using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using ConsoleApp3;

// List<int> numbers? = new List<int>();
//
// for (int i = 0; i < 10; i++)
// {
//     numbers.Add(i);
//     Console.Write(i);
// }

// LinkedList<string> list = new LinkedList<string>(
//     new[] { "Dima", "Kirill", "Andrey" }
//     );
// var currentNode = list.First;
//
// while (currentNode != null)
// {
//     Console.WriteLine(currentNode.Value);
//     currentNode = currentNode.Next;
// }



// List<int> numbers = new List<int>(){1,2,3,4,5,6,7,8,9,10};
//
//
// for (int i = numbers.Count; i >=1; i--)
// {
//     Console.Write(i);
// }


// List<int> numbers2 = new List<int>();
// for (int i = 0; i < 10; i++)
// {
//     var num = Convert.ToInt32(Console.ReadLine());
//     numbers2.Add(num);
// }
// numbers2.RemoveAll(x => x%2 == 0);
// Console.WriteLine(string.Join(",", numbers2));


//
// List<int> numbers2 = new List<int>(){1,2,3,4,5,6};
//
// LinkedList<string> list = new LinkedList<string>(
//     new[] { "Dima", "Kirill", "Andrey" }
//      );
//
//
//
// void RemoveFirstElement(List<int> elements, LinkedList<string> elements2)
// {
//    var sw=Stopwatch.StartNew();
//    while (elements.Count>0)
//    {
//        elements.RemoveAt(0);
//    }
//    sw.Stop();
//    Console.WriteLine(sw.ElapsedMilliseconds);
//    
//    
//    var sw2=Stopwatch.StartNew();
//    while (elements2.Count>0)
//    {
//        elements.RemoveAt(0);
//    }
//    sw.Stop();
//    Console.WriteLine(sw2.ElapsedMilliseconds);
// }
//
// RemoveFirstElement(numbers2, list);


// Queue<int> q = new Queue<int>();
// q.Enqueue(0);
// q.Enqueue(10);
// q.Enqueue(20);
//
// int a;
//
//
// while (q.TryDequeue(out a))
// {
//     Console.WriteLine(a);
// }
// Console.WriteLine(q.Count);


// var people = new Stack<string>();
// people.Push("John");
// people.Push("Doe");
// people.Push("Mary");
//
//
// string headPerson = people.Peek();
// Console.WriteLine(headPerson);
//
//
// string person1 = people.Pop();
// Console.WriteLine(person1);
// string person2 = people.Pop();
// Console.WriteLine(person2);
// string person3 = people.Pop();
// Console.WriteLine(person3);



        Queue<string> q = new Queue<string>();

// var a = Console.ReadLine();
//
//
// while (a != "exit")
// {
//     q.Enqueue(a);
//     var b = q.Dequeue();
//     Console.WriteLine(b);
// }


// var people = new Dictionary<string?, string?>()
// {
//     ["1"]="Dima", ["2"]="Armen"
// };
//
//
// Console.WriteLine("enter name");
// string name =Console.ReadLine();
// if (people.ContainsKey(name))
// {
//     Console.WriteLine($"{people[name]}");
// }

// var students=new Dictionary<Person,List<int>>();
//
// var Dima = new Person("Dmitriy");
//
//
//
// void AddStudent(Person p, List<int> grades)
// {
//     students.Add(p, grades);
// }
//
//
// void DisplayStudents(Dictionary<Person, List<int>> students)
// {
//     foreach (var stud in students)
//     {
//         Console.WriteLine($"Student Name: {stud.Key.Name} Grades: {String.Join(",", stud.Value)} ");
//     }
// }
//
//
//
//
// void AverageGrade(Dictionary<Person, List<int>> students)
// {
//     float result;
//     foreach (var student in students)
//     {
//         result = student.Value.Sum() / student.Value.Count;
//         Console.WriteLine($"Student name:{student.Key.Name}:  his midle grade {result} ");
//     }
// }
// AddStudent(Dima, new List<int>(){1,2,3});
// DisplayStudents(students);
// AverageGrade(students);


        // ArrayList list = new ArrayList();
        // list.Add(5.5);
        // list.Add(5);
        // list.AddRange(new string[]{"Hello", "World"});
        // list.Add(new string[]{"Hello", "Dima"});
        // list.Add(new List<string>{"Hello2", "Dima2"});
        //
        //
        // foreach (var var in list)
        // {
        //     if (var.GetType() == typeof(string[]))
        //     {
        //         foreach (var varik in (IEnumerable)var)
        //         {
        //             Console.WriteLine(varik);
        //     
        //         }
        //     }
        //     else
        //     {
        //         Console.WriteLine(var);
        //     }
        // }

        
// HashSet<string> set = new HashSet<string>();
//
//
// Console.WriteLine(set.Add("d"));
// Console.WriteLine(set.Add("d"));
// foreach (var varik in set)
// {
//         Console.WriteLine(varik);
// }
//
// HashSet<int> hset2 = new HashSet<int>()
// {
//         1,2,3,4,5,6,7,8,9,10,11,12
// };
//
// Console.WriteLine(string.Join(",", hset2));
        
//         
//         var test = new Tetsclass();    
//         var test2class = new Test2class();
//         
// test.SomeMethod(10);
// test2class.SomeMethod(10); 

//         var comp = new Computer(120);
//         var phone = new Phone(100);
// comp.PowerOn();   
// comp.ShowVoltage();
// comp.PowerOff();
// comp.ShowVoltage();
//
// phone.PowerOn();
// phone.ShowVoltage();
// comp.PowerOff();
// comp.ShowVoltage();

// List<Iprintable> printables = new List<Iprintable>();
// printables.Add(new Book());
// printables.Add(new Magazine());
// printables.Add(new Magazine());
// printables.Add(new Book());
//
// foreach (var var in printables)
// {
//         var.Print();
// }
//
// Magazine.printMagazines(printables);
// Book.printBooks(printables);
        
        // var kreditka = new CreditCard(100);
        // var paypal = new Paypal(100);

// kreditka.Pay(101);
// paypal.Pay(101);        
// Console.WriteLine(kreditka.balance);
// Console.WriteLine(paypal.balance);
// Checkout.Payment(paypal, 50);


        
        // Message mes = Welcome.Print;
        // Message mes2 = new Hello().Display;
// mes = Hello;
// mes = Hello2;        
// mes();
// mes();
// void Hello()=>Console.WriteLine("Hello");
// void Hello2()=>Console.WriteLine("Hello2");
//
//         mes();
//         mes2();
// delegate void Message();

//
//         Operation operation = Add;
//         int result = operation(10, 20);
//         Console.WriteLine(result);
//
//         operation = Multiply;
//         result = operation(10, 20);
//         Console.WriteLine(result);
//         
//         
// int Add(int a, int b)=>a+b;
// int Multiply(int a, int b)=>a*b;
// delegate int Operation(int a, int b);

//
//         Message message = Hello;
//         message += HowAreYou;
//         message();
//         message-= HowAreYou;
//         if (message != null) message();
//         
// void Hello()=>Console.WriteLine("Hello");
// void HowAreYou()=>Console.WriteLine("How are you?");


// delegate void Message();

//         Operation<int, int> doubleOperation = Double;
//         int result= doubleOperation(5);
//         Console.WriteLine(result);
//         int Double(int n) => n + n;
//
// delegate T Operation<T, K>(K value);


// DoOperation(10,20, Add);
//         void DoOperation(int a, int b, Operation op)
//         {
//                 Console.WriteLine($"Operation name : {op.Method.Name}  result:: {op(a,b)}");
//         }
// int Add(int a, int b)=>a+b;
// int Subtract(int a, int b)=>a-b;
// int Multiply(int a, int b)=>a*b;
//
// delegate int Operation(int a, int b);



// List<Operation> ops = new List<Operation>(){Add,Subtract,Multiply};
//
// void Show()
// {
//         foreach (var var in ops)
//         {
//                 Console.WriteLine(var(10,20));
//                 
//         }
// }        
//
//
// int Add(int a, int b)=>a+b;
// int Subtract(int a, int b)=>a-b;
// int Multiply(int a, int b)=>a*b;
// delegate int Operation(int a, int b);





//         PrintNumber example1 = PrintSquare;
//         example1(5);
//         
//         void PrintSquare(int n)=>Console.WriteLine(Math.Pow(n,2));        
// public delegate void PrintNumber(int num);



//
//         var operation = Selectoperation(OperationType.Add);
//         Console.WriteLine(operation(10,4));
//         
//         
//         var oper2 = Selectoperation(OperationType.Subtract);
//         Console.WriteLine(oper2(10,4));
//         
//         
//         
//         
//         Operation Selectoperation(OperationType ot)
//         {
//                 switch (ot)
//                 {
//                         case OperationType.Add: return Add;
//                         case OperationType.Subtract: return Subtract;
//                         default: return Multiply;
//                         
//                 }
//         }
//         
//         
//         
//         int Add(int a, int b)=>a+b;
//         int Subtract(int a, int b)=>a-b;
//         int Multiply(int a, int b)=>a*b;
//
//         enum OperationType
//         {
//                 Add,Subtract,Multiply
//         }
//
//
//
// delegate int Operation(int a, int b);

Account account=new Account(200);

account.Register(PrintMessage);
account.Register(PrintColourMessage);        
        
        account.Subtract(100);
        account.Subtract(101);
  
    
        
        
        
account.Unregister(PrintColourMessage);
        account.Subtract(40);


        
        
        
void PrintMessage(string s)=>Console.WriteLine(s);
void PrintColourMessage(string s)
{
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(s);
        Console.ResetColor();
}