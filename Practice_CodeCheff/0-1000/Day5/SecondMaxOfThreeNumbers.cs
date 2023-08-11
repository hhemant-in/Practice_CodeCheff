using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day5
{
    internal class SecondMaxOfThreeNumbers
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int firstNumber = int.Parse(InputCase[0]);
                int secondNumber = int.Parse(InputCase[1]);
                int thirdNumber= int.Parse(InputCase[2]);

                if((firstNumber > secondNumber && firstNumber < thirdNumber) || (firstNumber < secondNumber && firstNumber > thirdNumber))
                {
                    Console.WriteLine(firstNumber);
                }
                else if ((secondNumber > firstNumber && secondNumber < thirdNumber) || (secondNumber < firstNumber && secondNumber > thirdNumber))
                {
                    Console.WriteLine(secondNumber);
                }
                else
                {
                    Console.WriteLine(thirdNumber);
                }
            }
        }
    }
}
