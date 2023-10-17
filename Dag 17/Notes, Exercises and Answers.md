# ---------- 1 ----------
The following class exists:

```CSharp
public class Human
{
    public string name;
    public int age;
    public Human(string name, int age) 
    {
        name = name;
        age = age;
    }
}
```

The following code is used in Main:
```CSharp
Human h = new Human("Mark", 25);
Console.WriteLine(h.name);
```

What is the output of the code above?
	a. 25
	b. Error
	c. "Mark"
	d. ""

**Answer:** c !
The first line instantiates an object of the Class Human with a variable name: h using "Mark" as the name and 25 as the age as method parameters in the class constructor.

---

# ---------- 2 ----------
```CSharp
int num = 5;
for(int i = 0; i < num; i++)
{
    Console.WriteLine(i);
}
```

Which integers are printed in the for loop above?

**Answer:** The following integers will be printed:
```Output
0
1
2
3
4
```

---

# ---------- 3 ----------
```CSharp
int num = 4;
while (num>0)
{
    Console.WriteLine($"Number: {num}");
    num--;
}
```

What is the lowest number printed in the while loop above?

**Answer:**
1 is the lowest number printed.

The code above will print the value of the num variable before it is decreased in the line under the print command. Therefor the while loop will continue as long as num is larger than 0. When it is 0 the loop breaks.

---

# ---------- 4 ----------
```CSharp
List<int> numbers = new List<int>();
```

Using only a for loop, make the list contain the following: [1, 2, 3, 4, 5]

```CSharp
For(int = 1; i <= 5; i++ ){
    numbers.Add(i);
}
```
**Answer:** The for loop is build with the following:
* Initializer - is set to 1 - the first element of the expected output.
* Condition - the loop is set to continue as long as the condition of i being lower AND EQUAL to 5. The last element of the expected output.
* Iterator - is set to increment by 1 at each loop using i++ as a statement.

---

# ---------- 5 ----------
```CSharp
List<string> words = new List<string> { "Bunker", "Glass", "C#", "Blanket", "TV" };
List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
int number = 3;

foreach (int i in numbers)
{
    if(i >= numbers.Count-1)
    {
        break;
    }
    Console.WriteLine(words[i]);
}
```

Which words get printed in the for loop above?

**Answer:**
The ouput will be:
* Glass
* C#
* Blanket

The starting condition in the loop is the first element of the numbers list (1) so there for the first element of the list words ("Bunker") is skipped since it is zero-based.
The break out condition is set to break when the i initializer is above or equal to the amount of elements in numbers minus 1 (i >= numbers.Count-1). Therefor the last element is skipped.

---

# ---------- 6 ----------
```CSharp
for(int i = 0; i < 5; i++)
{
    for(int j = 0; j < 2; j++)
    {
        Console.WriteLine("C#");
    }
}
```

How many times does 'C#' get printed in the code above?
**Answer:** The output will be the string "C#" printed 10 times. The outer loop will "multiply" the inner loop 5 times (0-4) and the inner loop will run 2 times (0-1) each time the outer loop loops.

---

# ---------- 7 ----------
```CSharp
public static string Moria(string val1 = null, string val2 = null)
{
    if (val2 == null)
    {
        Console.WriteLine("Fail");
        return null;
    }
    else if (val2 == null && val1 != null)
    {
        Console.WriteLine("Fail");
        return null;
    }
    else if (val2 == null || val1 != null)
    {
        Console.WriteLine("Fail");
        return null;
    }
    else if(val1 == null && val2 == "friend")
    {
        Console.WriteLine("Enter");
        return val2;
    }
    else
    {
        Console.WriteLine("Fail");
        return null;
    }
}
```
How do you successfully get the Moria() method to print 'Enter' ?

**Answer:** By declaring the following two variables before calling the method:
* String val1 = null;
* String val2 = "friend";