using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000
{
    internal class SavingTaxes
    {
        internal void Start()
        {
            int NumberOfTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int amountEarned = int.Parse(InputCase[0]);
                int minimalTaxableAmount = int.Parse(InputCase[1]);

                Console.WriteLine(amountEarned - minimalTaxableAmount);
            }
        }
    }
}
