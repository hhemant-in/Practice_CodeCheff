using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day4
{
    internal class Parity
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                int numberOfChocolates = int.Parse(Console.ReadLine());

                Console.WriteLine(numberOfChocolates % 2 == 0 ? "YES" : "NO");
            }
        }
    }
}
