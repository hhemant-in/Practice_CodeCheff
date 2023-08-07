using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000
{
    internal class AddTwoNumbers
    {
        internal void Start()
        {
            int NumberOfTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int x = int.Parse(InputCase[0]);
                int y = int.Parse(InputCase[1]);
                PrintOutput(x + y);
            }

        }

        private void PrintOutput(int v)
        {
            Console.WriteLine(v);
        }
    }
}
