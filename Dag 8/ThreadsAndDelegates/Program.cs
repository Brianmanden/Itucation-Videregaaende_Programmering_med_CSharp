using System.Threading.Channels;

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

        //--- Exercise 2 ---
        //Create a delegate that accepts two numbers.
        //Now use your delegate with 4 different methods: Add, Subtract, Multiply, and Divide.
        #region Exercise 2
        private delegate double CalculatingDelegate(int i, int j);

        private static double Add(int i, int j)
        {
            return i + j;
        }

        private static double Subtract(int i, int j)
        {
            return i - j;
        }

        private static double Multiply(int i, int j)
        {
            return i * j;
        }

        private static double Divide(int i, int j)
        {
            return (double)i / j;
        }

        #endregion


        static void Main(string[] args)
        {
            // Exercise 1
            Thread evenThread =  new Thread(PrintEvenNumbers);
            evenThread.Start();

            Thread oddThread = new Thread(PrintOddNumbers);
            oddThread.Start();
            
            Console.WriteLine(Environment.NewLine);

            // Exercise 2
            CalculatingDelegate calcDel;
            calcDel = Add;
            calcDel += Subtract;
            calcDel += Multiply;
            calcDel += Divide;

            foreach (Delegate del in calcDel.GetInvocationList())
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"{del.Method.Name} method - Result: { del.DynamicInvoke(2, 3)}");
                Console.ForegroundColor = ConsoleColor.Gray;
            }

            Console.ReadKey();
        }
    }
}