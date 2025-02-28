using System;

interface IPrintable
{
    void Print();
}

interface ISerializable
{
    void SaveToFile();
}

class Report : IPrintable, ISerializable
{
    public void Print()
    {
        Console.WriteLine("Printing report details...");
    }

    public void SaveToFile()
    {
        Console.WriteLine("Saving report to file...");
    }
}