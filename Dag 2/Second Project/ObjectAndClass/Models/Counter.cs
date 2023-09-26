using static System.Net.Mime.MediaTypeNames;
using System.Diagnostics.Metrics;
using System;

namespace ObjectAndClass.Models
{
    //--- Exercise 1 ---
    //Class: Counter
    //A simple tally counter that increments its value by 1 every click.
    //Create the class with the following functionality:
    //- 'Empty' constructor(no positional arguments required)
    //- 'value' variable
    //- 'Click()' method
    //- 'Reset()' method
    //Decide how to display your current value: After each function call? Only when asked?
    //Create an object and test your class!

    public class Counter
    {
        private int value = 0;

        public Counter(){}

        public int Click()
        {
            value++;
            return value;
        }

        public void Reset()
        {
            value = 0;
        }
    }
}
