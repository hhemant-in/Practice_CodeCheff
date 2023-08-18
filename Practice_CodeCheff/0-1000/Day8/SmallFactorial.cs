using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day8
{
    internal class SmallFactorial
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                //string[] InputCase = Console.ReadLine().Split();

                int number = int.Parse(Console.ReadLine());
                Console.WriteLine(CalculateFactorial(number));
                Console.ReadKey();
            }
        }

        public static long CalculateFactorial(int number)
        {
            long factorial = 1;
            for (int i = 2; i <= number; i++)
            {
                factorial *= i;
            }

            return factorial;

        }
    }
}
