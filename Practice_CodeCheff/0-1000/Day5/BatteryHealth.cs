using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day5
{
    internal class BatteryHealth
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int batteryPercentage = int.Parse(InputCase[0]);

                Console.WriteLine(batteryPercentage >= 80 ? "YES" : "NO");
            }
        }
    }
}
