using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground
{
    public class SumOfMinimum
    {
        // This seed should return 26
        int[,] seed = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 5, 6, 7, 8, 9 }, { 20, 21, 34, 56, 100 } };
        public int GetSumOfMinimum()
        {
            int minSum = 0;
            for(int i = 0; i < seed.GetLength(0); i++)
            {
                int min = seed[i, 0];
                for(int j = 0; j < seed.GetLength(1); j++)
                {
                    if(seed[i, j] < min) min = seed[i, j];
                }
                minSum += min;
            }
            return minSum;
        }

    }
}
