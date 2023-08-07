using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000
{
    internal class GoodTurn
    {
        internal void Start()
        {
            int NumberOfTestCases = Convert.ToInt32(Console.ReadLine());
            if (NumberOfTestCases >= 1 && NumberOfTestCases <= 100)
            {
                for (int i = 0; i < NumberOfTestCases; i++)
                {
                    string[] InputCase = Console.ReadLine().Split();
                    int x = int.Parse(InputCase[0]);
                    int y = int.Parse(InputCase[1]);
                    PrintOutput(x + y); 
                }
            }
        }

        private void PrintOutput(int sumOfBothNumbers)
        {
            if (sumOfBothNumbers > 6)
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
