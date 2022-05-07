using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnormousInputNOutputTest
{
    public class Controllers
    {

        public int[] RunTest(int n)
        {
            var rnd = new Random();
            int[] nums = new int[n];
            for(int i = 0; i < n; i++)
            {
                int num1 = rnd.Next(0, 40000);
                int num2 = rnd.Next(0, 40000);
                nums[i] = num1 * num2;
            }
            return nums;
        }
    }
}
