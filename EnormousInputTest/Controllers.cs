using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnormousInputTest
{
    public class Controllers
    {
        public int runTest(int numCount, int divisionNum)
        {
            var rnd = new Random();
            int count = 0;

            for(int i = 0; i < numCount; i++)
            {
                int num = rnd.Next(1, (int)Math.Pow(10, 7));
                Console.WriteLine(num);
                if(num % divisionNum == 0) count++;
            }
             
            return count;
        }
    }
}
