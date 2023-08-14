using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day6
{
    internal class BullOrBear
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int boughtPrice = int.Parse(InputCase[0]);
                int soldPrice = int.Parse(InputCase[1]);

                if (boughtPrice > soldPrice)
                {
                    Console.WriteLine("LOSS");
                }
                else if (soldPrice > boughtPrice)
                {
                    Console.WriteLine("PROFIT");
                }
                else
                {
                    Console.WriteLine("NEUTRAL");
                }
            }
        }
    }
}
