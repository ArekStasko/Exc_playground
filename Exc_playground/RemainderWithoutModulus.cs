using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground
{
    internal class RemainderWithoutModulus
    {

        public int RemainderWithoutMod(int D, int d)
        {
            if (d > D) return D;
            return RemainderWithoutMod(D-d, d);
        }

    }
}
