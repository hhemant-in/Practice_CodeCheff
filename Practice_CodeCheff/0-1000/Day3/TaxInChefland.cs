﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day3
{
    internal class TaxInChefland
    {
        internal void Start()
        {
            int NumberOfTestCases = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < NumberOfTestCases; i++)
            {
                string[] InputCase = Console.ReadLine().Split();
                int income = int.Parse(InputCase[0]);

                if (income > 100)
                {
                    Console.WriteLine(income - 10);
                }
                else
                {
                    Console.WriteLine(income);
                }

            }
        }
    }
}
