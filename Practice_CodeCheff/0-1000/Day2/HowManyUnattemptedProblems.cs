using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day2
{
    internal class HowManyUnattemptedProblems
    {
        internal void Start()
        {
            string[] InputCase = Console.ReadLine().Split();
            int totalProblems = int.Parse(InputCase[0]);
            int problemsAttempted = int.Parse(InputCase[1]);

            Console.WriteLine(totalProblems - problemsAttempted);
        }
    }
}
