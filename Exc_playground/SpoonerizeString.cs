using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground
{
    internal class SpoonerizeString
    {
        public string Spoonerize(string str)
        {
            Stack<string> strLetters = new Stack<string>();
            List<string> StringParts = str.Split(' ').ToList();
            foreach(string strPart in StringParts) strLetters.Push(strPart[0].ToString());
            for (int i = 0; i < StringParts.Count; i++)
            {
                StringParts[i] = strLetters.Pop() + StringParts[i].Substring(1);
            }

            return String.Join(" ", StringParts);
        }

    }
}
