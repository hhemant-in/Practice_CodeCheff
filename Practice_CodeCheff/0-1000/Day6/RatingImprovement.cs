using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day6
{
    internal class RatingImprovement
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int cheffRating = int.Parse(InputCase[0]);
                int diffLevel = int.Parse(InputCase[1]);

                if(cheffRating <= diffLevel && diffLevel <= (cheffRating +200) )
                {
                    Console.WriteLine("YES");
                }
                else
                    Console.WriteLine("NO");
            }
        }
    }
}
