using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallengeP1
{
    class Problem4
    {
        public void Begin()
        {
            Console.WriteLine(@"4. Create a method that takes an array of positive and negative numbers. Return an array where the first element is the count of the positive numbers and the second element is the sum of negative numbers. 
        a. Use case: [7, 9, -3, -32, 107, -1, 36, 95, -14, -99, 21]");
            int i = 0;
            int userInput = 0;
            int arrayElement = 0;
            int[] result = { 0, 0 };
            while (userInput < 1 || userInput > 20)
            {


                Console.WriteLine("Enter the length of the Array:(1 - 20)");
                userInput = Convert.ToInt32(Console.ReadLine());
            }

            List<int> digits = new List<int>();

            for (int j = 0; j < userInput; j++)
            {
                Console.WriteLine("Enter a number for element " + j + ": ");
                arrayElement = Convert.ToInt32(Console.ReadLine());
                digits.Add(arrayElement);
            }

            List<int> numberList = new List<int>();

            foreach (int h in digits)
            {
                if (h < 0)
                {
                    result[1] += h;
                }
                if (h > 0)
                {
                    numberList.Add(h);
                }

            }
            result[0] = numberList.Count();
            Console.WriteLine(result[0] + ", " + result[1]);
            Console.ReadKey();
        }
    }
}
