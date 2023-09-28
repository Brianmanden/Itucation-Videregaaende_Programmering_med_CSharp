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

            for (int i = 1; i < 20; i++)
            {
                if (i % 2 == 1)
                {
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
            do
            {
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
                else
                {
                    Console.WriteLine("Ticket price is: 15$");
                }

                tries--;
            }
            while (tries > 0);

            Console.WriteLine(Environment.NewLine);
            #endregion

            //---Exercise 4---
            #region Exercise 4

            //a.Write a loop that prompts the user to enter a series of pizza toppings until they break the loop.
            //As they enter each topping, print a message saying you'll add that topping to their pizza.
            #region a.
            Console.WriteLine("Pizza (a)");

            string topping = string.Empty;
            Console.WriteLine("Add topping to pizza. Type 'done' when done");
            do
            {
                Console.WriteLine("Which topping ?");
                topping = Console.ReadLine();

                if (topping != "done")
                {
                    Console.WriteLine($"Thank you. Will add {topping} to pizza.");
                    Console.WriteLine(Environment.NewLine);
                }
            } while (topping != "done");
            Console.WriteLine(Environment.NewLine);
            #endregion

            //b.Modify your pizza program to include a list of the toppings the user enters.
            //When the loop breaks, print a message confirming their order has been saved, along with a list of their desired toppings.
            #region b.
            Console.WriteLine("Pizza (b)");

            string toppingB = string.Empty;
            List<string> toppingsList = new List<string>();
            Console.WriteLine("Add topping to pizza. Type 'done' when done");
            do
            {
                Console.WriteLine("Which topping (b) ?");
                toppingB = Console.ReadLine();

                if (toppingB != "done")
                {
                    Console.WriteLine($"Thank you. Will add {toppingB} to pizza.");
                    toppingsList.Add(toppingB);
                    Console.WriteLine(Environment.NewLine);
                }
            } while (toppingB != "done");
            Console.WriteLine("Thank you for your pizza (b) order.");
            Console.WriteLine("You have chosen the following toppings:");
            foreach (string pizzatopping in toppingsList)
            {
                Console.WriteLine($"* {pizzatopping}");
            }
            Console.WriteLine(Environment.NewLine);

            #endregion

            //c.Before adding a topping to the list of desired toppings, check whether the topping is already added.
            //Tell the user that that topping already exists in their order.
            #region c.
            Console.WriteLine("Pizza (c)");

            string toppingC = string.Empty;
            List<string> toppingsListC = new List<string>();
            Console.WriteLine("Add topping to pizza. Type 'done' when done");
            do
            {
                Console.WriteLine("Which topping (c) ?");
                toppingC = Console.ReadLine()!;

                if (toppingC != "done")
                {
                    if (toppingsListC.Contains(toppingC))
                    {
                        Console.WriteLine($"Toppings list already contains: {toppingC}");
                    }
                    else
                    {
                        Console.WriteLine($"Thank you. Will add {toppingC} to pizza.");
                        toppingsListC.Add(toppingC);
                    }
                    Console.WriteLine(Environment.NewLine);
                }
            } while (toppingC != "done");

            Console.WriteLine("Thank you for your pizza (c) order.");
            Console.WriteLine("You have chosen the following toppings:");
            foreach (string pizzatopping in toppingsListC)
            {
                Console.WriteLine($"* {pizzatopping}");
            }
            Console.WriteLine(Environment.NewLine);
            #endregion

            #endregion

            Console.WriteLine("End of program. Press any key.");
            Console.ReadKey();
        }
    }
}