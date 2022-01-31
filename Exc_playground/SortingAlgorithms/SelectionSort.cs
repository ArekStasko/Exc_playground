using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground.SortingAlgorithms
{
    public class SelectionSort
    {
        
        public void selectionSort<T>(T[] arrToSort) where T : IComparable
        {
            for(int i = 0; i < arrToSort.Length; i++)
            {
                int minIndex = i;
                T minValue = arrToSort[minIndex];

                for(int j = i + 1; j < arrToSort.Length; j++)
                {
                    if(arrToSort[j].CompareTo(minValue) < 0)
                    {
                        minIndex = j;
                        minValue = arrToSort[j];
                    }
                }
                
                Swap(arrToSort, i, minIndex);
            }
        }

        private void Swap<T>(T[] arr, int elIndex, int minIndex)
        {
            T temp = arr[elIndex];
            arr[elIndex] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }
}
