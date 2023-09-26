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

#region Exercise 4

Console.WriteLine("Students");

Student s1 = new Student();
s1.Name = "Jonna";
s1.AddTest(4);
s1.AddTest(7);
s1.AddTest(2);
s1.AddTest(10);
s1.GetTotalScore();

Console.WriteLine($"Test information for {s1.Name}. Total score: {s1.GetTotalScore()} - Average score: { s1.GetAverageScore()}");

Student s2 = new Student();
s2.Name = "Ejner";
s2.AddTest(3);
s2.AddTest(3);
s2.AddTest(1);
s2.GetTotalScore();
s2.GetAverageScore();

Console.WriteLine($"Test information for {s2.Name}. Total score: {s2.GetTotalScore()} - Average score: {s2.GetAverageScore()}");


#endregion

Console.WriteLine();
