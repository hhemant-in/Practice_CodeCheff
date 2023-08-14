using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day6
{
    internal class EqualDistribution
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int totalChocolates = int.Parse(InputCase[0]) + int.Parse(InputCase[1]);

                Console.WriteLine(totalChocolates % 2 == 0 ? "YES" : "NO");
            }
        }
    }
}
