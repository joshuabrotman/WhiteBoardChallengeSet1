using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhiteboardChallengeP1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;

            while (userInput < 1)
            {
                Console.WriteLine("Enter a problem to solve(int 1 through 10): ");
                userInput = Convert.ToInt32(Console.ReadLine());
            }

            switch (userInput)
            {
                case 1:
                    Problem1 problem = new Problem1();
                    problem.Begin();
                    break;
                case 2:
                    Problem2 problem2 = new Problem2();
                    problem2.Begin();
                    break;
                case 3:
                    Problem3 problem3 = new Problem3();
                    problem3.Begin();
                    break;
                case 4:
                    Problem4 problem4 = new Problem4();
                    problem4.Begin();
                    break;
                case 5:
                    Problem5 problem5 = new Problem5();
                    problem5.Begin();
                    break;
                case 6:
                    Problem6 problem6 = new Problem6();
                    problem6.Begin();
                    break;
                case 7:
                    Problem7 problem7 = new Problem7();
                    problem7.Begin();
                    break;
                case 8:
                    Problem8 problem8 = new Problem8();
                    problem8.Begin();
                    break;
                case 9:
                    Problem9 problem9 = new Problem9();
                    problem9.Begin();
                    break;
                case 10:
                    Problem10 problem10 = new Problem10();
                    problem10.Begin();
                    break;
            }
            
        }
    }
}
