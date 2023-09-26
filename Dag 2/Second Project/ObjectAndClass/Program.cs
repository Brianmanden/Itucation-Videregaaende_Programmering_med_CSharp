using ObjectAndClass.Models;

#region Exercise 1
Console.WriteLine("Tally counter");

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
Dice dice = new Dice();

Console.WriteLine("Dice roll history");
// Roll die multiple times
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();
dice.Roll();

// Loop through roll history and print each roll
foreach (var roll in dice.RollHistory())
{
    Console.WriteLine(roll);
}

Console.WriteLine(Environment.NewLine);

#endregion

#region Exercise 3

int sides = 20;
Console.WriteLine($"Rolling {sides}-sided die");

DiceVariousSides newDice = new DiceVariousSides(sides);
Console.WriteLine(newDice.Roll());
Console.WriteLine(newDice.Roll());
Console.WriteLine(newDice.Roll());
Console.WriteLine(newDice.Roll());
Console.WriteLine(newDice.Roll());
Console.WriteLine(newDice.Roll());
Console.WriteLine(newDice.Roll());
Console.WriteLine(newDice.Roll());
Console.WriteLine(Environment.NewLine);

sides = 3;
Console.WriteLine($"Rolling {sides}-sided die");

DiceVariousSides AnotherNewDice = new DiceVariousSides(sides);
Console.WriteLine(AnotherNewDice.Roll());
Console.WriteLine(AnotherNewDice.Roll());
Console.WriteLine(AnotherNewDice.Roll());
Console.WriteLine(Environment.NewLine);

#endregion

Console.WriteLine();
