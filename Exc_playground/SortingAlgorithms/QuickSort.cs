using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground.SortingAlgorithms
{
    public class QuickSort
    {
        public void sort<T>(T[] nums) where T : IComparable
        {
            sort(nums, 0, nums.Length - 1);
        }

        private T[] sort<T>(T[] nums, int lower, int upper) where T : IComparable
        {
            if(lower < upper)
            {
                int p = Partition(nums, lower, upper);
                sort(nums, lower, p);
                sort(nums, upper, p);
            }
            return nums;
        }

        private int Partition<T>(T[] nums, int lower, int upper) where T : IComparable
        {
            int i = lower;
            int j = upper;

            T pivot =nums[lower];
            do
            {
                while (nums[i].CompareTo(pivot) < 0) i++;

                while (nums[j].CompareTo(pivot) > 0) j--;

                if (1 >= j) break;
                swap(nums, i, j);

            } while (i <= j);

            return j;
        }

        private void swap<T>(T[] nums, int lower, int upper)
        {
            T temp = nums[upper];
            nums[upper] = nums[lower];
            nums[lower] = temp;
        }
    }
}
