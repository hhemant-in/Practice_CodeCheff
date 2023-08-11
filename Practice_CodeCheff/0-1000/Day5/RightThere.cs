using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day5
{
    internal class RightThere
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int totalPeople = int.Parse(InputCase[0]);
                int hallCapacity = int.Parse(InputCase[1]);

                Console.WriteLine(hallCapacity >= totalPeople ? "YES" : "NO");
            }
        }
    }
}
