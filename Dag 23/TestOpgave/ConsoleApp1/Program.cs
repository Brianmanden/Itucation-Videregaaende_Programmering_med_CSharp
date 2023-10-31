using System;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Reflection;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Program
    {
        //static void Main(string[] args)
        //{
        //    //Console.WriteLine("Hello, World!");

        //    //------Exercise 1------
        //    //Fill in the print statement below such that you:
        //    //Compare the numbers 20 and 5 and show which one is bigger.
        //    //Use the ternary operator.
        //    //Only write a single line of code.

        //    Console.WriteLine(20 > 5 ? "20 is bigger than 5" : "5 is bigger than 20");

        //    Console.ReadLine();
        //}

        //--------- Exercise 2 ---------
        //The Car class has to implement the IAutomobile interface. Modify the code to make sure this happens.
        //You can assume that the interface stays empty.
        //Run your code to check your output(expected output: True)
        //public interface IAutomobile
        //{
        //    // Empty Interface
        //}

        //public class Car : IAutomobile
        //{
        //    public string brand;
        //    public Car()
        //    {
        //        brand = "Ferrari";
        //    }
        //}

        //static void Main(string[] args)
        //{
        //    Car ferrari = new Car();
        //    Console.WriteLine((typeof(IAutomobile).IsAssignableFrom(ferrari.GetType())));

        //    Console.ReadLine();
        //}

        //--------- Exercise 3 ---------
        //delegate void Del(string s);
        //static void Main(string[] args)
        //{
        //    void Notify(string s)
        //    {
        //        Console.WriteLine($"I hereby notify you: {s}");
        //    }
        //    // Code would go here
        //    Del del = Notify;
        //    del.Invoke("Hej");

        //    Console.ReadLine();
        //}

        //What is the correct way(s) to instantiate the delegate:
        //>>>1. Del d1 = Notify;
        //2. Del d1 = new Notify;
        //>>>3. Del d1 = new Del(Notify);
        //4. Del d1 = new Del(Notify("Hej"));

        //--------- Exercise 4 ---------
        //Which statement(s) is true for a HashSet:
        //>>>1. It does not allow duplicate elements.
        //2. It can only be used with numbers.
        //>>>3. It is an unordered collection.
        //4. It can never increase in size.

        //--------- Exercise 5 ---------
        //Which statement(s) is true for an Interface:
        //1. Interfaces must include the keyword 'abstract'
        //>>>2. You cannot instantiate an Interface.
        //3. Interfaces can never use properties.
        //>>>4. Interfaces usually start their name with the letter 'I'

        //--------- Exercise 6 ---------
        //Which statement(s) is true for a variable:
        //1. A concept that can only be used with value types.
        //2. Variable names have no restrictions.
        //>>>3. Variables are named memory locations.
        //4. You can never assign a new value to an existing variable.

        // Selv
        // ---------------------------------------------------------------------------------------------------------------------------------
        // Team work - Josefine, Jeppe og gennemgang i klassen

        //--------- Exercise 7 ---------
        //Which statement(s) is true for a Constructor:
        //>>>1. Every class has a constructor.
        //2. Constructors must be invoked explicitly.
        //>>>3. A Constructor has no return type.
        //4. Constructors can have any name you want.

        //--------- Exercise 8 ---------
        //Which statement(s) is true for inheritance in C#:
        //>>>1. Derived classes can access members with the protected keyword.
        //2. A class can inherit from multiple base classes.
        //>>>3. A sub class can override methods in the base class.
        //4. Methods can never be inherited.

        //--------- Exercise 9 ---------
        //Which statement(s) is true for delegates:
        //>>>1. A delegate represents references to methods with a particular return type.
        //>>>2. A delegate object can be composed using the "+" operator
        //3. Delegates must be inherited.
        //>>>4. A single delegate can invoke more than one method.

    }
}