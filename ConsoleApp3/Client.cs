namespace ConsoleApp3;

public class Client
{
    public string Name{get;set;}
    public int Age{get;set;}
    public bool IsActive = false;


    public Client(string name, int age, bool isActive)
    {
        Name = name;
        Age = age;
        IsActive = isActive;
    }
}