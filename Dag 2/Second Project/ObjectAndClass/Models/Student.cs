using System.Runtime.CompilerServices;

namespace ObjectAndClass.Models
{
    //--- Exercise 4 ---
    //Class: Student
    //For the purpose of this exercise, a student has a name and a test score based on the tests they've taken.
    //- 'AddTest(score)'
    //- 'GetTotalScore()'
    //- 'GetAverageScore()'
    //Which variables does your class need when you construct it?
    //Implement the class and create an object to test it!

    public class Student
    {
        private int _testsTaken = 0;
        private int _totalScore = 0;

        public string Name { get; set; }

        public void AddTest(int score)
        {
            _totalScore += score;
            _testsTaken++;
        }

        public int GetTotalScore()
        {
            return _totalScore;
        }

        public double GetAverageScore()
        {
            double average = (double)_totalScore / (double)_testsTaken;
            return average;
        }
    }
}
