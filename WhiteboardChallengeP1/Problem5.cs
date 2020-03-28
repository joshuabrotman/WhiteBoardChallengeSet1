using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WhiteboardChallengeP1
{
    class Problem5
    {
        public void Begin()
        {
            Console.WriteLine(@"    5. Create a method that accepts a string of space separated numbers and returns the highest and lowest number as a string
        a. Use case: “3 9 0 1 4 8 10 2” -> “0 10”");
    
            string userInput = "";
 
            Console.WriteLine("Enter a string of space-separated integers:");
            userInput = Console.ReadLine();

            List<int> numberList = ConvertToList(userInput);
            Console.WriteLine(numberList.Min() + " " + numberList.Max());
            Console.ReadKey();
            


        }


        public List<int> ConvertToList(string userInput)
        {
            List<int> numberList = new List<int>();
            string[] numberArray = Regex.Split(userInput, @"\D+");
            foreach (string value in numberArray)
            {
                if (!string.IsNullOrEmpty(value))
                {
                    int i = int.Parse(value);
                    numberList.Add(i);
                }
            }
            return numberList;
        }
    }
}
