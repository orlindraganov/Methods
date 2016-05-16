using System;


class Hello
{
    static void SayHello(string name)
    {
        string helloName = "Hello, " + name + '!';
        Console.WriteLine(helloName);
    }

    static void Main()
    {
        string name = Console.ReadLine();

        SayHello(name);

    }
}