using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day6
{
    internal class ChairsRequirement
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int studentNumber = int.Parse(InputCase[0]);
                int existingChairsNumber = int.Parse(InputCase[1]);

                Console.WriteLine(studentNumber > existingChairsNumber ? studentNumber - existingChairsNumber : 0);

            }
        }
    }
}
