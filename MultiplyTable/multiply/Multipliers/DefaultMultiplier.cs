using multiply.Interfaces;

namespace multiply.Multipliers
{
    public class DefaultMultiplier : IMultiplier
    {
        public int[,] BuildMultiplierTable(int rows, int columns)
        {
            int[,] result = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i,j] = (i + 1)*(j + 1);
                }
            }

            return result;
        }
    }
}