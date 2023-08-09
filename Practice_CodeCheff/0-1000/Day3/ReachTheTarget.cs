using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day3
{
    internal class ReachTheTarget
    {
        internal void Start()
        {
            int NumberOfTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int targetScore = int.Parse(InputCase[0]);
                int currentScore = int.Parse(InputCase[1]);

                Console.WriteLine(targetScore - currentScore);
            }
        }
    }
}
