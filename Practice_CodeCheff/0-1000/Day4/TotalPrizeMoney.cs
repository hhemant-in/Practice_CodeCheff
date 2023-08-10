using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day4
{
    internal class TotalPrizeMoney
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int prizeMoneyTopTen = int.Parse(InputCase[0]);
                int restPrizeMoney = int.Parse(InputCase[1]);

                Console.WriteLine(10 * prizeMoneyTopTen + 90 * restPrizeMoney);
            }
        }
    }
}
