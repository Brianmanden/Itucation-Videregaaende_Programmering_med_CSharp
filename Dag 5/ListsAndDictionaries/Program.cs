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

            Console.ReadKey();
        }
    }
}