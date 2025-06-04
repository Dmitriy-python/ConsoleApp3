namespace ConsoleApp3;

public class Rectangle:IGeometrical,IDrawable
{
    
    public void GetPerimeter()
    {
      Console.WriteLine("(a+b)*2");
    }

    public void GetArea()
    {
        Console.WriteLine("(a*b)");
    }

    public void Draw()
    {
        Console.WriteLine("Rectangle");
    }
}