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



