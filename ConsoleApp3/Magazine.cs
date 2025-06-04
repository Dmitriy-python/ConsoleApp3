namespace ConsoleApp3;

public class Magazine: Iprintable
{
    public void Print()
    {
        Console.WriteLine("Magazine");
    }


    public static void printMagazines(List<Iprintable> printable)
    {
        foreach (var var in printable)
        {
            if (var is Magazine magazine)
            {
                magazine.Print();
            }
        }
    }
}