using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day4
{
    internal class CandyDivision
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                int numberOfCandies = int.Parse(Console.ReadLine());

                if (numberOfCandies % 3 == 0)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }

        }
    }
}
