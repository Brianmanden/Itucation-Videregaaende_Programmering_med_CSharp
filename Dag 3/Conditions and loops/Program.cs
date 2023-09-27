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

            Console.ReadKey();
        }
    }
}