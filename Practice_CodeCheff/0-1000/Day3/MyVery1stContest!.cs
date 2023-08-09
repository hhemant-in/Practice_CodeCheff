using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_CodeCheff._0_1000.Day3
{
    internal class MyVery1stContest_
    {
        internal void Start()
        {
            string[] InputCase = Console.ReadLine().Split();
            int totalNumberOfNewUsers = int.Parse(InputCase[0]);
            int zeroSolvedSubmissionUsers = int.Parse(InputCase[1]);
            int submissionFailures = int.Parse(InputCase[2]);

            int newUsersAbove1000Rating = totalNumberOfNewUsers - zeroSolvedSubmissionUsers - submissionFailures;
            Console.WriteLine("{0} {1}", totalNumberOfNewUsers - zeroSolvedSubmissionUsers, newUsersAbove1000Rating);
        }
    }
}
