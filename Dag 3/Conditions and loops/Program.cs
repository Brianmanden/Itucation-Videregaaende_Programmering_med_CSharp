using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System;

namespace Conditions_and_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---Exercise 1---
            //Use a for loop to print each odd number from 1 to 20.
            #region Exercise 1
            Console.WriteLine("List uneven numbers.");

            for (int i = 0; i < 20; i++) { 
                if (i % 2 == 1) {
                    Console.WriteLine($"{i} is an uneven number.");
                }
            }
            Console.WriteLine(Environment.NewLine);
            #endregion

            //---Exercise 2---
            //Write code that accepts an input until the user guesses a magic word.
            //Give them a reasonable amount of guesses until the loop ends by itself.
            //Print a message and break the loop when their guess is correct.
            #region Exercise 2

            int numberOfTries = 5;
            string magicPhrase = "OpenSesame";
            string textInput = string.Empty;

            do
            {
                Console.WriteLine($"{numberOfTries} tries back.");
                Console.WriteLine("Input magic word");
                textInput = Console.ReadLine();

                numberOfTries--;
            }
            while (numberOfTries > 0 && magicPhrase != textInput);

            if (magicPhrase == textInput)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Too bad. No more tries");
            }

            Console.WriteLine(Environment.NewLine);
            #endregion

            //---Exercise 3---
            //A movie theater charges different ticket prices depending on a peron's age.
            //If a person is under the age of 3, the ticket is free; if they are between 3 and 12, the ticket is $10;
            //and if they are over age 12, the ticket is $15.Write code in which you ask the users for an age, and then
            //tell them the cost of a movie ticket.
            #region Exercise 3

            Console.WriteLine("Movie Theatre");
            Console.WriteLine("Price ranges:");
            Console.WriteLine("Age under 3 - price is free");
            Console.WriteLine("Age between 3 and up to and including 12 - price is 10$");
            Console.WriteLine("Age over 12 - price is 15$");

            int age = 0;
            int tries = 3;
            do {
                Console.WriteLine("What is the age of the person going to the movie theatre ?");
                age = int.Parse(Console.ReadLine());

                if (age < 3)
                {
                    Console.WriteLine("Ticket is free of charge.");
                }
                else if (age >= 3 && age <= 12)
                {
                    Console.WriteLine("Ticket price is: 10$");
                }
                else { 
                    Console.WriteLine("Ticket price is: 15$");
                }

                tries--;
            }
            while (tries > 0);

            Console.WriteLine(Environment.NewLine);
            #endregion

            Console.ReadKey();
        }
    }
}