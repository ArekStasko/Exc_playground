using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsEfficiency
{
    internal class Controllers
    {
        public Dictionary<string, List<int[]>> DataArrays = new Dictionary<string, List<int[]>>();

        

        public void InitializeArrays(int ElementsCount)
        {
            DataArrays.Add("RandomArrays", new List<int[]> { });
            DataArrays.Add("SortedArrays", new List<int[]> { });
            DataArrays.Add("ReversedArrays", new List<int[]> { });
            DataArrays.Add("AlmostSortedArrays", new List<int[]> { });
            DataArrays.Add("FewUniqueArrays", new List<int[]> { });


            for (int i = 0; i < 3; i++)
                DataArrays["RandomArrays"].Add(GetRandomNumbersArray(ElementsCount));

            for (int i = 0; i < 3; i++)
                DataArrays["SortedArrays"].Add(GetSortedArray(ElementsCount));


            for (int i = 0; i < 3; i++)
            {
                int[] arr = GetSortedArray(ElementsCount);
                Array.Reverse(arr);
                DataArrays["ReversedArrays"].Add(arr);
            }

            for(int i = 0; i <3; i++)
            {
                int[] almostSortedArray = GetSortedArray(ElementsCount)[0..(ElementsCount / 2)];
                int[] randomizedArray = GetRandomNumbersArray(ElementsCount)[(ElementsCount / 2)..ElementsCount];
                int[] arr = almostSortedArray.Concat(randomizedArray).ToArray();
                DataArrays["AlmostSortedArrays"].Add(arr);
            }

            for(int i = 0; i < 3; i++)
                DataArrays["FewUniqueArrays"].Add(GetArrWithUniqueElem(ElementsCount));
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
