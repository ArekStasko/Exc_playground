

namespace Exc_playground
{
    internal class MultiplicationTable
    {
        internal int[,] table = new int[10,10];

        public MultiplicationTable() => CreateMultiplicationTable();

        private void CreateMultiplicationTable()
        {
            for (int i = 0; i < table.GetLength(0); i++)
            {
                table[0, i] = i+1;
            }

            for (int i = 1; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    table[i, j] = table[0,j] + table[i-1, j];
                }
            }
        }
    }
}
