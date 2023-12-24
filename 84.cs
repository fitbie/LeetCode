public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int result = 0;

        for (int i = 0; i < heights.Length; i++)
        {
            int tempResult = heights[i];
            
            for (int j = i + 1; j < heights.Length; j++)
            {
                if (heights[i] <= heights[j]) { tempResult += heights[i]; }
                else break;
            }

            for (int k = i -1; k >= 0; k--)
            {
                if (heights[i] <= heights[k]) { tempResult += heights[i]; }
                else break;
            }

            result = result < tempResult ? tempResult : result;
        }

        return result;
    }
}