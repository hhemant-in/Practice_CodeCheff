using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day4
{
    internal class ChefAndBrainSpeed
    {
        internal void Start()
        {
            string[] InputCase = Console.ReadLine().Split();
            int threshHoldLimit = int.Parse(InputCase[0]);
            int currentWorkingRate = int.Parse(InputCase[1]);

            if(currentWorkingRate > threshHoldLimit)
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
