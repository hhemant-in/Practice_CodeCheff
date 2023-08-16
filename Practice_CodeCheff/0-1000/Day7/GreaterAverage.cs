using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day7
{
    internal class GreaterAverage
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int sum = int.Parse(InputCase[0]) + int.Parse(InputCase[1]);
                double average = (double)sum / 2;
                Console.WriteLine(average > int.Parse(InputCase[2]) ? "YES" : "NO");
            }
        }
    }
}
