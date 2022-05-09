using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground
{
    public class Playground
    {

        public void Revert(string[] toRev)
        {
            int stepCount = 1;
            Console.WriteLine($"Items count : {toRev.Length}");

            for(int i = 0; i < (toRev.Length/2); i++)
            {
                Console.WriteLine($"Step : {stepCount}");
                string a = toRev[i];
                toRev[i] = toRev[^(i + 1)];
                toRev[^(i + 1)] = a;
                stepCount++;
            }
        }

    }
}
