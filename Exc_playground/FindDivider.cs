using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground
{
    public class FindDivider
    {
        public int divider(int num1, int num2)
        {
            if (num2 == 0) return num1;
            int r = num1 % num2;
            return divider(num2, r);
        }
    }
}
