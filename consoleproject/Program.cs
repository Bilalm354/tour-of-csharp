﻿using System;

namespace consoleproject
{
    class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Hello everyone";
            Console.WriteLine(greeting);
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine("Hello there," +name)
        }
    }
}
