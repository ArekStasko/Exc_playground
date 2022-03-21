using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground
{
    public class ConsecutiveStrings
    {
        public string findString(string[] arr, int k)
        {
            if (arr.Length == 0 || k <= 0 || k > arr.Length) return "";

            List<string> longestElements = new List<string>();

            while (k > 0)
            {
                string element = arr[0];
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[j].Length > element.Length && !longestElements.Contains(arr[j]))
                        element = arr[j];
                }
                longestElements.Add(element);
                element = "";
                k--;
            }

            return String.Join("", longestElements.ToArray());
        }

    }
}
