using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground
{
    public class ModifiedSum
    {
        public static int GetModifiedSum(int[] a, int n)
        {
            int sum = 0;
            for(int i = 0; i< a.Length; i++)
            {
                sum += (int)Math.Pow(a[i], n);
            }

            int arrSum = a.Sum();
            return sum - arrSum;
        }
    }
}
