using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsEfficiency
{
    internal class Controllers
    {
        public List<int[]> RandomArrays = new List<int[]>();
        public List<int[]> SortedArrays = new List<int[]>();
        public List<int[]> ReversedArrays = new List<int[]>();
        public List<int[]> AlmostSortedArrays = new List<int[]>();
        public List<int[]> FewUniqueArrays = new List<int[]>();


        public void InitializeArrays(int ElementsCount)
        {
            Console.WriteLine("Initialize array with custom numbers...");

            for(int i = 0; i < 3; i++)
                RandomArrays.Add(GetRandomNumbersArray(ElementsCount));

            Console.WriteLine("Initialize array with sorted numbers...");

            for (int i = 0; i < 3; i++)
                SortedArrays.Add(GetSortedArray(ElementsCount));

            Console.WriteLine("Initialize array with reversed numbers...");
            
            for(int i = 0; i < 3; i++)
            {
                int[] arr = GetSortedArray(ElementsCount);
                Array.Reverse(arr);
                ReversedArrays.Add(arr);
            }

            Console.WriteLine("Initialize array with almost sorted elements...");

            for(int i = 0; i <3; i++)
            {
                int[] almostSortedArray = GetSortedArray(ElementsCount)[0..(ElementsCount / 2)];
                int[] randomizedArray = GetRandomNumbersArray(ElementsCount)[(ElementsCount / 2)..ElementsCount];
                int[] arr = almostSortedArray.Concat(randomizedArray).ToArray();
                AlmostSortedArrays.Add(arr);
            }

            Console.WriteLine("Initialize array with few unique elements...");

            for(int i = 0; i < 3; i++)
                FewUniqueArrays.Add(GetArrWithUniqueElem(ElementsCount));

            Console.WriteLine("End of initializing data");
        }

        private int[] GetArrWithUniqueElem(int ElementsCount)
        {
            int[] arr = GetSortedArray(ElementsCount);

            var random = new Random();

            for(int i = 0; i < (ElementsCount*0.1); i++)
            {
                arr[random.Next(0, ElementsCount-1)] = random.Next(0, 20000);
            }

            return arr;
        }

        private int[] GetSortedArray(int ElementsCount)
        {
            int[] arr = GetRandomNumbersArray(ElementsCount);
            Array.Sort(arr);
            return arr;
        }

        private int[] GetRandomNumbersArray(int ElementsCount)
        {
            int[] arr = new int[ElementsCount];

            var random = new Random();
            for(int i = 0; i < ElementsCount; i++)
                arr[i] = random.Next(0, 20000);
         
            return arr;
        }
    }
}
