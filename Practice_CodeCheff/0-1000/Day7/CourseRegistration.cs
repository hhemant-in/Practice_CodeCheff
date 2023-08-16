using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day7
{
    internal class CourseRegistration
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();

                Console.WriteLine(int.Parse(InputCase[1]) - int.Parse(InputCase[2]) >= int.Parse(InputCase[0]) ? "YES" : "NO");
            }
        }
    }
}
