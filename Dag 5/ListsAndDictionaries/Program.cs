namespace ListsAndDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---Exercise 1: Lists---

            //a.Store the names of a few of your friends in a list.
            //Print each person's name one at a time.
            List<string> friendsList = new List<string>
            {
                "Albert",
                "Niels",
                "John",
                "Richard",
                "Paul",
                "Joe"
            };

            foreach (string friend in friendsList)
            {
                Console.WriteLine($"'Friend': {friend}");
            }


            Console.WriteLine(Environment.NewLine);


            //b.Think of a hobby of yours, and make a list that stores several examples of items from that hobby.
            //Use your list to print a series of statements about these items, such as "Squirtle is a pretty cool dude."
            List<string> dotnetHobbyItems = new List<string>
            {
                "C#",
                "Datatypes",
                "Arrays",
                "Lists",
                "Collections"
            };

            Console.WriteLine($"{dotnetHobbyItems[0]} is a programming language in the .Net Framework.");
            Console.WriteLine($"It contains a lot of {dotnetHobbyItems[1]}.");
            Console.WriteLine($"Some examples are: {dotnetHobbyItems[2]}, {dotnetHobbyItems[3]}, {dotnetHobbyItems[4]}.");

            Console.ReadKey();
        }
    }
}