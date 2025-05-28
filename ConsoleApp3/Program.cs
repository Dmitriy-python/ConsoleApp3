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


// Проверка логина
//
// Условие:
// Метод Login(string username)
// Если строка пуста — выбрось ArgumentNullException.
//     Если длина < 4 — выбрось Exception с сообщением: “Слишком короткий логин”


using System.Globalization;
using System.Xml;

void Login(string username, string password)
{
    try
    {
        try
        {
            if (username.Length==0)
            {
                throw new ArgumentException();

            }
            else if (username.Length<4)
            {
               Console.WriteLine("Username is too short");
            }
        }
        
        catch
        {
            Console.WriteLine("Exception occured");
            throw;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
}


Login("sss", "sss+");


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



