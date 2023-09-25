using System;

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
            Console.WriteLine(Environment.NewLine);

            //---Exercise 2-- -
            //a.Use a variable to represent a person's name, and print a message to that person. 
            //   Your message should just be something simple, such as "Greetings name, are you ready for an adventure?"
            string name = "Mark";
            Console.WriteLine($"Greetings {name}, are you ready for an adventure?");
            Console.WriteLine(Environment.NewLine);

            //b.Use a variable to represent a person's name, and then print that person's name in
            //   lowercase and uppercase
            string nameMixedCase = "Svend Erik";
            Console.WriteLine(nameMixedCase.ToLower());
            Console.WriteLine(nameMixedCase.ToUpper());
            Console.WriteLine(Environment.NewLine);

            //c.Find a cool quote you like. Print the quote and the name of its author.
            //   The output has to include quotation marks!
            string quote = "\"An expert is a person who has made all the mistakes that can be made in a very narrow field.\"";
            string author = "Niels Bohr";
            Console.WriteLine(quote);
            Console.WriteLine(author);
            Console.WriteLine(Environment.NewLine);

            //d.Repeat 2 - c, but this time represent the famous person's name using a variable called famous_person.
            //   Then compose your message, and represent it with a new variable called message. Print your message!
            string famous_person = "Anders Hejlsberg";
            string newQuote = "Happiness comes from within";
            message = $"\"{newQuote}\" --- {famous_person}";
            Console.WriteLine(message);
            Console.WriteLine(Environment.NewLine);

            //e.Use a variable to represent a person's name, but include some whitespace in the beginning and the end of the name.
            //   Print the name once with the whitespace, then three more times stripping the left, right, and total whitespace.
            string famous_person2 = " Donald Knuth ";
            Console.WriteLine(famous_person2);
            Console.WriteLine(famous_person2.TrimStart());
            Console.WriteLine(famous_person2.TrimEnd());
            Console.WriteLine(famous_person2.Trim());
            Console.WriteLine(Environment.NewLine);
        }
    }
}
