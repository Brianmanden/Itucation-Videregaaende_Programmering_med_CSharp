namespace ThreadsAndDelegates
{
    internal class Program
    {
        //---Exercise 1---
        //Using two threads: 
        //Make the first thread print the even numbers from 1 - 20, 
        //and the second thread print the odd numbers.
        #region Exercise 1
        private static void PrintEvenNumbers(){
            for (int i = 2; i < 20; i+=2) {
                Console.WriteLine($"Counting even numbers: { i }");
                Thread.Sleep(100);
            }
        }

        private static void PrintOddNumbers(){
            for (int i = 1; i < 20; i += 2)
            {
                Console.WriteLine($"Counting odd numbers: {i}");
                Thread.Sleep(100);
            }
        }
        #endregion

        static void Main(string[] args)
        {
            Thread evenThread =  new Thread(PrintEvenNumbers);
            evenThread.Start();

            Thread oddThread = new Thread(PrintOddNumbers);
            oddThread.Start();
        
            Console.ReadKey();
        }
    }
}