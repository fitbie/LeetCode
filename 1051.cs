public class Solution {
    public int HeightChecker(int[] heights)
    {
        int result = 0;
        // int i = 0; // Either.
        // foreach(var h in heights.Order())
        // {
        //     if (h != heights[i]) { result++; }
        //     i++;
        // }

        int[] heightsIncreasing = new int[heights.Length];
        Array.Copy(heights, heightsIncreasing, heights.Length);
        Array.Sort(heightsIncreasing);

        for (int i = 0; i < heights.Length; i++)
        {
            if (heights[i] != heightsIncreasing[i]) { result++; }
        }

        return result;
    }
}