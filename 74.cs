Solution solution = new();
// solution.SearchMatrix(new int[][] { new int[] { 1,3,5,7 }, new int[] { 10,11,16,20 }, new int[] { 23,30,34,60 } }, 16);
solution.SearchMatrix(new int[][] { new int[] { 1, 1 } }, 2);


public class Solution {
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int left = -1;
        int right = matrix.Length * matrix[0].Length;

        while (left < right - 1)
        {
            int middle = (left + right) / 2;
            
            int row = middle / matrix[0].Length;
            int column = middle % matrix[0].Length;
            
            if (matrix[row][column] > target) { right = middle; }            
            if (matrix[row][column] < target) { left = middle; }            
            if (matrix[row][column] == target) { return true; }            
        }

        return false;
    }
}