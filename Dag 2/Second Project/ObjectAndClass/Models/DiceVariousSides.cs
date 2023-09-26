public class DiceVariousSides
{
    //--- Exercise 3 ---
    //Class: Die
    //An n-sided die that can be rolled!
    //(If you want to keep your old class intact, you can create this one with a different name.)
    //- This time, every die you create takes an int (sides) as a parameter.
    //- Consider which changes you have to make.
    //- Implement the 'Roll()' function.

    private int _sides = 0;

    public DiceVariousSides(int sides)
    {
        _sides = sides;
    }

    public int Roll()
    {
        Random rnd = new Random();
        int theRoll = rnd.Next(1, _sides + 1);
        return theRoll;
    }
}