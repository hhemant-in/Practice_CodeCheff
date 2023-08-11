using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day5
{
    internal class CountingWords
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int numberOfPages = int.Parse(InputCase[0]);
                int numberOfWords = int.Parse(InputCase[1]);

                Console.WriteLine(numberOfPages  * numberOfWords);
            }
        }
    }
}
