using ObjectAndClass.Models;

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
