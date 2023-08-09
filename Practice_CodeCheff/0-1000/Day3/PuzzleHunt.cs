using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day3
{
    internal class PuzzleHunt
    {
        internal void Start()
        {
            string[] InputCase = Console.ReadLine().Split();
            int numberOfMembersInTeam = int.Parse(InputCase[0]);

            if (numberOfMembersInTeam >= 6 && numberOfMembersInTeam <= 8)
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
