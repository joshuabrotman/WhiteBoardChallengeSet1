using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallengeP1
{
    class Problem3
    {
        public void Begin()
        {
            Console.WriteLine(@"3. Given a list of integers, return a bool that represents whether or not all integers in the list can form a sequence of incrementing integers
        a. Use case: 
            i. {5, 7, 3, 8, 6} -> false (no 4 to complete the sequence)
            ii. {17, 15, 20, 19, 21, 16, 18} -> true");
            int i = 0;
            int userInput = 0;
            int arrayElement = 0;
            while (userInput < 1 || userInput > 10)
            {


                Console.WriteLine("Enter the length of the Array:(1 - 10)");
                userInput = Convert.ToInt32(Console.ReadLine());
            }

            List<int> digits = new List<int>();

            for (int j = 0; j < userInput; j++)
            {
                Console.WriteLine("Enter a number for element " + j + ": ");
                arrayElement = Convert.ToInt32(Console.ReadLine());
                digits.Add(arrayElement);
            }

            if (CheckIfListIncriments(digits) == true)
            {
                Console.WriteLine("True. the list increments");
            }
            else
            {
                Console.WriteLine("False. The list does not increment.");
            }
            Console.ReadLine();
        }

        public bool CheckIfListIncriments(List<int> digits)
        {
            int totalMatches = 0;
            for(int i = 0; i < digits.Count;i++)
            {
                foreach(int j in digits)
                {
                    if(i+1 == j)
                    {
                        totalMatches++;
                    }
                }
            }

            if(totalMatches == digits.Count)
            {
                return true;
            }
            
            return false;
        }
    }
}
