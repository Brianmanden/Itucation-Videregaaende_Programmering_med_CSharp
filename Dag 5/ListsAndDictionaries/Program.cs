using Spectre.Console;

namespace ListsAndDictionaries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //---Exercise 1: Lists---
            #region Exercise 1

            //a.Store the names of a few of your friends in a list.
            //Print each person's name one at a time.
            List<string> friendsList = new List<string>
            {
                "Albert",
                "Niels",
                "John",
                "Richard F.",
                "Richard D.",
                "Lex",
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
            #endregion

            Console.WriteLine(Environment.NewLine);

            //---Exercise 2: Modifying Lists ---
            #region Exercise 2

            //a.If you could invite anyone, living or otherwise, to dinner, who would you invite?
            //Make a list that includes at least three people you'd like to invite to dinner.
            //Use your list to print a message to each person, inviting them to dinner.
            List<string> dinnerGuests = friendsList.GetRange(0, 3);

            foreach (var guest in dinnerGuests)
            {
                Console.WriteLine($"Dear {guest}.\t Please come be my guest. There will be food ... and beer!");
            }

            //b.You just heard that one of your guests can't make the dinner :(
            //You'll have to think of someone else to invite. Modify your list, 
            //replacing the name of the guest who can't make it with the name of a new person.
            //Print an invitation for your new guest.

            // Albert is dead - Joe is alive.
            dinnerGuests[0] = "Joe";
            Console.WriteLine($"Dear {dinnerGuests[0].ToString()}.\t Please come be my guest. There will be food ... and beer!");

            Console.WriteLine(Environment.NewLine);

            //c.You just found a bigger dinner table! Think of three more guests to invite.
            //Add your new guests to the end of your list.
            dinnerGuests.Add(friendsList[3]);
            dinnerGuests.Add(friendsList[4]);
            dinnerGuests.Add(friendsList[5]);
            dinnerGuests.Add(friendsList[6]);

            foreach (string guest in dinnerGuests) {
                Console.WriteLine($"Dear {guest},");
                Console.Write("Please come be my guest. There will be food ... and beer!");
                Console.WriteLine(Environment.NewLine);
            }

            Console.WriteLine(Environment.NewLine);

            //d.Oh no! You just found out that your new dinner table won't arrive in time.
            //Find a way to uninvite the new guests from 2 - c.
            List<string> soSorryList = dinnerGuests.GetRange(3, dinnerGuests.Count - 3);

            foreach (var tooBadMate in soSorryList)
            {
                Console.WriteLine($"Dear {tooBadMate},");
                Console.Write("I am sorry to inform you that the new dinner table hasn´t arrived.");
                Console.Write("There will not be enough seats so I will have to cancel your invitation.");
                Console.WriteLine(Environment.NewLine);
            }
            #endregion

            Console.WriteLine(Environment.NewLine);

            //---Exercise 3: Dictionaries---
            #region Exercise 3
            //a.Use a dictionary to store information about a person you know.
            //You decide the information, but classics include first name, age, and showers per week.
            //Print a little message about your friend, using the stored information.

            Dictionary<string, int> friendsDict = new Dictionary<string, int>();
            friendsDict.Add("Anna", 3);
            friendsDict.Add("Bob", 2);
            friendsDict.Add("Charlie", 4);
            friendsDict.Add("Devin", 1);

            foreach (var friend in friendsDict)
            {
                Console.WriteLine($"{friend.Key}... said 'Hello' to the world {friend.Value} times this week.");
            }

            Console.WriteLine(Environment.NewLine);

            //b.Use a dictionary to store the names of a few people you know, along with their favourite numbers.
            //Print some of the people in your dictionary, along with their favourite number.
            Dictionary<string, int> knownPeople = new Dictionary<string, int>();
            knownPeople.Add("Penton", 5);
            knownPeople.Add("Beast", 666);
            knownPeople.Add("Douglas", 42);

            Console.WriteLine($"Favorite number of {knownPeople.ElementAt(1).Key} is {knownPeople.ElementAt(1).Value}");
            Console.WriteLine($"Favorite number of {knownPeople.ElementAt(2).Key} is {knownPeople.ElementAt(2).Value}");

            Console.WriteLine(Environment.NewLine);

            //c.Let's use a dictionary as an actual dictionary (or you could call it a glossary to avoid confusion).
            //Think of five programming words you've learned about, and store them along with their meanings.
            //Print these words and their meanings as a neatly formatted output.

            Dictionary<string, string> glossary = new Dictionary<string, string>();
            glossary.Add("Variable", "A named container for a value.");
            glossary.Add("Integer", "The representation of a whole number.");
            glossary.Add("Array", "A simple list for a set of values.");
            glossary.Add("List", "A list for a set of values. List has methods attached to it.");
            glossary.Add("LinkedList", "A list of nodes. Each node knows about the next node (if any) in line - hence linked list.");

            var table = new Table();
            table.Border = TableBorder.HeavyHead;
            table.BorderColor(Color.Green);

            table.AddColumn("[deepskyblue1]Term[/]");
            table.AddColumn(new TableColumn("[green]Meaning[/]"));

            foreach (var term in glossary)
            {
                table.AddRow($"[white]{term.Key}[/]", term.Value);
            }

            AnsiConsole.Write(table);

            Console.WriteLine(Environment.NewLine);

            #endregion

            Console.ReadKey();
        }
    }
}