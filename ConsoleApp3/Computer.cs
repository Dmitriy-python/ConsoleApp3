namespace ConsoleApp3;

public class Computer: ISwitchable
{
    public int Voltage { get; set; }

    public bool IsOn = true;

    
    public Computer(int voltage)
    {
        Voltage = voltage;
    }
    
    

    
    public void PowerOn()
    {
        IsOn = true;
        Console.WriteLine("Powered On");
    }

    public void PowerOff()
    {
        IsOn = false;
        Console.WriteLine("Powered Off");
    }

    
    public void ShowVoltage()
    {
        if (IsOn is false)
        {
           Console.WriteLine("Power is off");
        }
        else
        {
            Console.WriteLine("Power is on , voltage"+Voltage);
        }
        
    }
}