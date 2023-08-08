using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day2
{
    internal class Burgers
    {
        internal void Start()
        {
            int NumberOfTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int numberOnDice = int.Parse(InputCase[0]);

                if (numberOnDice == 6)
                {
                    Console.WriteLine("YES");
                }
                else
                {
                    Console.WriteLine("NO");
                }
            }
        }
    }
}
