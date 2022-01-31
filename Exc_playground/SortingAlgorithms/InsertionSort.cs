namespace Exc_playground.SortingAlgorithms
{
    public class InsertionSort
    {
        public void insertionSort(int[] arrToSort)
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

        private void Swap(int[] arr, int elIndex, int minIndex)
        {
            int temp = arr[elIndex];
            arr[elIndex] = arr[minIndex];
            arr[minIndex] = temp;
        }
    }
}
