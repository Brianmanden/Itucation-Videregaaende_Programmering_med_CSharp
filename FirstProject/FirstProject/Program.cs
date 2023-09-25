using System;
using Spectre;
using Spectre.Console;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region TMP

            //int x = 19;
            //Console.WriteLine(x);

            //string name = "* Brian *";
            //Console.WriteLine(name);

            //string y = "12";
            //x = 14;

            //Console.WriteLine(x+y);
            //Console.WriteLine(int.Parse(y) + x);

            //AnsiConsole.Write(
            //    new FigletText("Output:")
            //            .LeftJustified()
            //            .Color(Color.Green)
            //    );
            //AnsiConsole.MarkupLine("[red]Name: [/]" + name);

            //Console.ReadKey();
            #endregion

            //---Exercise 1---
            //a.Assign a message to a variable and then print that message.
            string message = "some message";
            Console.WriteLine(message);

            //b.Assign a message to a variable, and print that message.
            //Then change the value of the variable to a new message, and print the new message.
            string someOtherMessage = "other message";
            Console.WriteLine(someOtherMessage);
            someOtherMessage = "new message";
            Console.WriteLine(someOtherMessage);
        }
    }
}
