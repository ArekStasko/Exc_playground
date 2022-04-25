using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsEfficiency
{
    internal class AlgorithmsImplenentations
    {
        public void MergeSort(int[] arr, int l, int r)
        {
            if (l < r)
            {
                int m = l + (r - l) / 2;
                MergeSort(arr, l, m);
                MergeSort(arr, m + 1, r);
                merge(arr, l, m, r);
            }
        }

        public void InsertionSort(int[] arrToSort)
        {
            int minIndex = 0;

            for (int i = 1; i < arrToSort.Length; i++)
            {

                if (arrToSort[minIndex] > arrToSort[i])
                {
                    for (int j = i; j > 0; j--)
                    {
                        if (arrToSort[j] < arrToSort[j - 1])
                        {
                            Swap(arrToSort, j, j - 1);
                        }
                        else
                            break;
                    }
                }
                else
                {
                    minIndex = i;
                }
            }
        }

        public void QuickSort(int[] nums)
        {
            sort(nums, 0, nums.Length - 1);
        }

        private int[] sort(int[] nums, int lower, int upper)
        {
            if (lower < upper)
            {
                int p = Partition(nums, lower, upper);
                sort(nums, lower, p);
                sort(nums, upper, p);
            }
            return nums;
        }

        private int Partition(int[] nums, int lower, int upper)
        {
            int i = lower;
            int j = upper;

            int pivot = nums[lower];
            do
            {
                while (nums[i].CompareTo(pivot) < 0) i++;

                while (nums[j].CompareTo(pivot) > 0) j--;

                if (1 >= j) break;
                Swap(nums, i, j);

            } while (i <= j);

            return j;
        }

        private void merge(int[] arr, int l, int m, int r)
        {
            int n1 = m - l + 1;
            int n2 = r - m;

            int[] L = new int[n1];
            int[] R = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
                L[i] = arr[l + i];
            for (j = 0; j < n2; ++j)
                R[j] = arr[m + 1 + j];

            i = 0;
            j = 0;

            int k = l;
            while (i < n1 && j < n2)
            {
                if (L[i] <= R[j])
                {
                    arr[k] = L[i];
                    i++;
                }
                else
                {
                    arr[k] = R[j];
                    j++;
                }
                k++;
            }

            while (i < n1)
            {
                arr[k] = L[i];
                i++;
                k++;
            }

            while (j < n2)
            {
                arr[k] = R[j];
                j++;
                k++;
            }
        }

        private void Swap(int[] arr, int elIndex, int minIndex)
        {
            int temp = arr[elIndex];
            arr[elIndex] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }
}
