using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day2
{
    internal class BiryaniClasses
    {
        internal void Start()
        {
            int NumberOfTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int weeks = int.Parse(InputCase[0]);
                int costPerWeek = int.Parse(InputCase[0]);


                Console.WriteLine(weeks * costPerWeek);

            }
        }
    }
}
