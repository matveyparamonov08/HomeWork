using System.Collections.Generic;
using System;
public class MobileApp
{
    public virtual void TurnOn()
    {
        Console.WriteLine("Turned On");
        Console.WriteLine('\n');
    }
    
}

class Text : MobileApp
{
    public override void TurnOn()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write("Текст");
        }
        Console.WriteLine('\n');
    }
}

class Count : MobileApp
{
    public override void TurnOn()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"{i*10} зелибоб ");
        }
        Console.WriteLine('\n');
    }
}

class Program
{
    public static void Main(string[] args)
    {
        MobileApp mobileApp = new MobileApp();
        MobileApp textApp = new Text();
        MobileApp countApp = new Count();
        mobileApp.TurnOn();
        textApp.TurnOn();
        countApp.TurnOn();
    }
}