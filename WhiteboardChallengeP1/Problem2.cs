using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallengeP1
{
    class Problem2
    {
        public void Begin()
        {
            Console.WriteLine("2.Palindrome is a word, phrase, or sequence that reads the same backward as forward i.e.madam.Write code that takes a user input and checks to see if it is a Palindrome and reports the result. You must handle spaces. ");
            Console.WriteLine("Please enter a palindrome (or not) utilizing strings, and I will tell you if it is a palindrome:");
            string userInput = Console.ReadLine();
            Console.WriteLine(userInput.SequenceEqual(userInput.Reverse()));
            Console.ReadLine();
        }
    }
}
