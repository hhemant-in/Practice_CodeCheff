using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day4
{
    internal class CodeChefLearnProblemSolving
    {
        internal void Start()
        {
            string[] InputCase = Console.ReadLine().Split();
            int numberOfLanguages = int.Parse(InputCase[0]);

            Console.WriteLine(numberOfLanguages * 2);            
        }
    }
}
