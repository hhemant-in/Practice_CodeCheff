using System;
using System.Linq;

namespace Practice_CodeCheff._0_1000.Day7
{
    internal class DistinctColors
    {
        internal void Start()
        {
            int NumberOfTestCases = int.Parse(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();

                int numberOfColors = int.Parse(InputCase[0]);
                int[] numberOfBallsByColor = new int[numberOfColors];
                for (int j = 0; j < numberOfColors; i++)
                {
                    numberOfBallsByColor[j] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine(numberOfBallsByColor.Max().ToString());
            }
        }
    }
}
