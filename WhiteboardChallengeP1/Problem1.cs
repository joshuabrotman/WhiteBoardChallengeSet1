using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallengeP1
{
    class Problem1
    {

        public void Begin()
        {
            Console.WriteLine(@"    1. Given an array of integers, return indices of the two numbers such that they add up to a specific target. You may assume that each input would have exactly one solution, and you may not use the same element twice.
        a.Use Case:
            i.Given numbers in an array: [5, 17, 77, 50]
            ii.Target: 55");
            int i = 0;
            int userInput = 0;
            int arrayElement = 0;
            while (userInput < 1 || userInput > 10) {


                Console.WriteLine("Enter the length of the Array:(1 - 10)");
                userInput = Convert.ToInt32(Console.ReadLine());
            }

            int[] digits = new int[userInput];

            for(int j = 0; j < userInput; j++)
            {
                Console.WriteLine("Enter a number for element " + j + ": ");
                arrayElement = Convert.ToInt32(Console.ReadLine());
                digits[j] = arrayElement;
            }

            int target = 0;
            Console.WriteLine("Enter the target value:");
            target = Convert.ToInt32(Console.ReadLine());

            List<int> winningIndicies = FindIndicieSumForTarget(digits, target);
            Console.WriteLine(winningIndicies[0] + " " + winningIndicies[1]);
            Console.ReadKey();
        }


        public List<int> FindIndicieSumForTarget(int[] digits, int target)
        {
            List<int> winningIndicies = new List<int>();

            int i = 0;
            while(i<digits.Length - 1)
            {
                for (int j = 0; j <= digits.Length-1; j++)
                {
                    if(digits[i]+digits[j] == target)
                    {
                        winningIndicies.Add(i);
                        winningIndicies.Add(j);
                    }
                }
                i++;
            }

           
            
            return winningIndicies;
        }
    }
}
