using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day3
{
    internal class TourOfKing
    {
        internal void Start()
        {
            int NumberOfTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int fiveCarCapacaity = int.Parse(InputCase[0]);
                int sevenCarCapactity = int.Parse(InputCase[1]);

                Console.WriteLine((5 * fiveCarCapacaity) + (7 * sevenCarCapactity));
            }
        }
    }
}
