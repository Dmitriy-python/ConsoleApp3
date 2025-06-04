namespace ConsoleApp3;

public class Book: Iprintable
{
    public void Print()
    {
        Console.WriteLine("Book");
    }
    
    
        
    public static void printBooks(List<Iprintable> printable)
    {
        foreach (var var in printable)
        {
            if (!typeof(Magazine).IsInstanceOfType(var))
            {
                Console.WriteLine("This type is not a Magazine, this is a Book type");
            }
        }
    }
}