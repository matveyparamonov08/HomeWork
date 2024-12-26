using System;
using System.Collections.Generic;

class SmartGadget
{
    bool vkl = false;

    virtual public void turnOn()
    {
        if (vkl) vkl = false;
        else vkl = true;
    }

    public bool info()
    {
        return vkl;
    }
}

class SmartLamp : SmartGadget
{
    bool vkl = false;

    override public void turnOn()
    {
        if (vkl) vkl = false;
        else vkl = true;
    }
}

class SmartTeaPot : SmartGadget
{
    bool vkl = false;

    override public void turnOn()
    {
        if (vkl) vkl = false;
        else vkl = true;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        SmartGadget g = new SmartGadget();
        SmartGadget g1 = new SmartTeaPot();
        Console.WriteLine(g.info());
        g.turnOn();
        Console.WriteLine(g.info());
        Console.WriteLine(g1.info());
    }
}