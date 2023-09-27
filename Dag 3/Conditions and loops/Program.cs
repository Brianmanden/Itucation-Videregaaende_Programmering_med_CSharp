namespace Conditions_and_loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---Exercise 1---
            //Use a for loop to print each odd number from 1 to 20.
            #region Exercise 1
            for (int i = 0; i < 20; i++) { 
                if (i % 2 == 1) {
                    Console.WriteLine($"{i} is an uneven number.");
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}