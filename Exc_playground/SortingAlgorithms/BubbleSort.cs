using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exc_playground.SortingAlgorithms
{
    internal class BubbleSort
    {

        public int[] sort(int[] nums)
        {
            for (int i = nums.Length; i > 0; i--)
            {
                bool isAnyChange = true;
                int minIndex = 0;
                for (int j = 1; j < i; j++)
                {
                    int minValue = nums[minIndex];
                    if (minValue > nums[j])
                    {
                        isAnyChange = false;
                        swap(nums, minIndex, j);
                    }
                    minIndex = j;
                }
                if (isAnyChange) break;
            }
            return nums;
        }

        private void swap(int[] nums, int lowIndex, int highIndex)
        {
            int temp = nums[highIndex];
            nums[highIndex] = nums[lowIndex];
            nums[lowIndex] = temp;  
        }

    }
}
