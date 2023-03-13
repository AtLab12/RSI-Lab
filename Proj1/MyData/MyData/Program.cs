using System;

public class MyData
{
    public static void Info()
    {
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello {name}, today is {DateTime.Now.ToString("d")}");
        Console.WriteLine("Current C# version: " + Environment.Version);
    }
}


namespace RSI {
    class MainClass
    {
        static void Main(string[] args)
        {
            MyData.Info();
        }
    }
}