namespace ConsoleApp3;

public class Test2class: ITest
{
    
    public int Property { get; set; }
    public void SomeMethod(int a)
    {
        Console.WriteLine(a*2);
    }
}