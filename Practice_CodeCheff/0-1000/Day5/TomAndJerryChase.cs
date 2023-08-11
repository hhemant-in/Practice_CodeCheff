using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day5
{
    internal class TomAndJerryChase
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int jerrySpeed = int.Parse(InputCase[0]);
                int tomSpeed= int.Parse(InputCase[1]);

                Console.WriteLine(tomSpeed > jerrySpeed ? "YES" : "NO"); 
            }
        }
    }
}
