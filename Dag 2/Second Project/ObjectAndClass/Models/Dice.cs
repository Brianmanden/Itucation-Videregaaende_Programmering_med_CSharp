namespace ObjectAndClass.Models
{
    //--- Exercise 2 ---
    //Class: Die
    //A 6-sided die that can be rolled!
    //- Consider how/if to keep track of your 6 sides.
    //- Implement a 'Roll()' method, which returns a random integer(1 - 6)
    //hint: The Random class is very helpful

    public class Dice
    {
        private IList<int> _rolls = new List<int>();

        public int Roll()
        {
            Random rnd = new Random();
            int theRoll = rnd.Next(1, 7);
            _rolls.Add(theRoll);
            return theRoll;
        }

        public IList<int> RollHistory()
        {
            return _rolls;
        }
    }
}
