using System;
using ScrabbleScore.Models;
using System.Collections.Generic;

namespace ScrabbleScore
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a word:");
            string userEnteredWord = (Console.ReadLine()).ToUpper();
            ScrabbleS scrabbleObject = new ScrabbleS();
            int score = scrabbleObject.GetScore(userEnteredWord);
            Console.WriteLine("You entered word " + userEnteredWord + " and your score is " + score);
        }
    }
}
