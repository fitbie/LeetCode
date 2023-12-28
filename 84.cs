public class Solution
{
    public int LargestRectangleArea(int[] heights)
    {
        int[] results = new int[heights.Length];
        int result = 0;

        Stack<int> nextSmaller = new();

        for (int i = heights.Length - 1; i >= 0; i--)
        {
            while (nextSmaller.TryPeek(out int next))
            {
                if (heights[next] >= heights[i])
                {
                    nextSmaller.Pop();
                }
                else
                {
                    results[i] = heights[i] * (next - i);
                    nextSmaller.Push(i);
                    break;
                }
            }

            if (nextSmaller.Count == 0) { results[i] = heights[i] * (heights.Length - i); nextSmaller.Push(i); }
        }
        
        nextSmaller.Clear();

        for (int i = 0; i < heights.Length; i++)
        {
            while (nextSmaller.TryPeek(out int prev))
            {
                if (heights[prev] >= heights[i])
                {
                    nextSmaller.Pop();
                }
                else
                {
                    results[i] += heights[i] * (i - prev - 1);
                    nextSmaller.Push(i);
                    break;
                }
            }

            if (nextSmaller.Count == 0) { results[i] += heights[i] * i; nextSmaller.Push(i); }
            
            result = result < results[i] ? results[i] : result;
        }

        return result;
    }
}