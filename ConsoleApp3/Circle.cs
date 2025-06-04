namespace ConsoleApp3;

public class Circle:IGeometrical,IDrawable
{
    
    public void GetPerimeter()
    {
        Console.WriteLine("2*pi*r");
    }

    public void GetArea()
    {
        Console.WriteLine("pi*r^2");
    }

    public void Draw()
    {
        Console.WriteLine("Circle");
    }
}