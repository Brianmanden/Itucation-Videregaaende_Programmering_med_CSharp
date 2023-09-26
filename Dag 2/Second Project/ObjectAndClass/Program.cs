using ObjectAndClass.Models;

#region Exercise 1

Counter counter = new Counter();

// Click tally counter a few times
counter.Click();
counter.Click();
int currentVal = counter.Click();

Console.WriteLine($"Current tally counter value is now: {currentVal}");

// Reset the counter
counter.Reset();

// Click another time
currentVal = counter.Click();
Console.WriteLine($"Current tally counter value is now: {currentVal}");
Console.WriteLine(Environment.NewLine);

#endregion

#region Exercise 2

// Instantiate new die
Die die = new Die();

// Roll die multiple times
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();
die.Roll();

// Loop through roll history and print each roll
foreach (var roll in die.RollHistory())
{
    Console.WriteLine(roll);
}

Console.WriteLine(Environment.NewLine);

#endregion

Console.WriteLine();