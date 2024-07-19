public class Solution {
    public IList<int> LuckyNumbers (int[][] matrix) 
    {
        int[] rowsMin = new int[matrix.Length];
        int[] columnsMax = new int[matrix[0].Length];

        for (int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[row].Length; col++)
            {
                int current = matrix[row][col];

                if (rowsMin[row] == 0 || rowsMin[row] > current)
                {
                    rowsMin[row] = current;
                }
                if (columnsMax[col] < current)
                {
                    columnsMax[col] = current;
                }
            }
        }

        return rowsMin.Intersect(columnsMax).ToList(); 
    }
}