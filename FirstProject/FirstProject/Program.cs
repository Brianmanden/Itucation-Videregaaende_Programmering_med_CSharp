using System;
using Spectre;
using Spectre.Console;

namespace FirstProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 19;
            Console.WriteLine(x);

            string name = "* Brian *";
            Console.WriteLine(name);

            string y = "12";
            x = 14;

            Console.WriteLine(x+y);
            Console.WriteLine(int.Parse(y) + x);

            AnsiConsole.Write(
                new FigletText("Output:")
                        .LeftJustified()
                        .Color(Color.Green)
                );
            AnsiConsole.MarkupLine("[red]Name: [/]" + name);

            Console.ReadKey();
        }
    }
}
