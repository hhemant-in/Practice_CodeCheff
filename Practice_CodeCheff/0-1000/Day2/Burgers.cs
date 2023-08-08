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
                int numberOfPatty = int.Parse(InputCase[0]);
                int numberOfBuns = int.Parse(InputCase[1]);

                if (numberOfBuns <= numberOfPatty)
                {
                    Console.WriteLine(numberOfBuns);
                }
                else
                {
                    Console.WriteLine(numberOfPatty);
                }
            }
        }
    }
}
