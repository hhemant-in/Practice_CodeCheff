using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day4
{
    internal class _2000
    {
        internal void Start()
        {
            string[] InputCase = Console.ReadLine().Split();
            int numberOF2000Notes = int.Parse(InputCase[0]);

            Console.WriteLine("{0}", 4 * numberOF2000Notes);
        }
    }
}
