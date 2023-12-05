Solution solution = new();
solution.Trap(new int[] { 0,7,1,4,6 });


public class Solution
{
    public int Trap(int[] height)
    {
        int result = 0;
        Stack<int> stack = new();
        int[] nextIndexes = new int[height.Length];

        for (int i = height.Length - 1; i >= 0; i--)
        {
            if (stack.Count == 0) { stack.Push(i); nextIndexes[i] = -1; continue; }

            int last = stack.Peek(); 
            if (height[last] >= height[i]) 
            { 
                stack.Push(i);
                nextIndexes[i] = last;
            }
            else
            {
                while(stack.TryPeek(out int next))
                {
                    if (height[next] < height[i]) { stack.Pop(); }
                    else { stack.Push(i); nextIndexes[i] = next; break; }
                }
                if (stack.Count == 0) { stack.Push(i); nextIndexes[i] = -1; }
            }
        }

        for (int pointer = 0; pointer < height.Length - 1;)
        {
            int rightMin, leftMax = 0;
            if (nextIndexes[pointer] == -1)
            {
                if (nextIndexes[pointer+1] == -1) { pointer++; continue;}
                else 
                {
                    int temp = pointer + 1;
                    while (nextIndexes[temp+1] != -1)
                    {
                        temp++;
                    }
                    rightMin = nextIndexes[temp]; leftMax = pointer;
                    int i = rightMin - 1;
                    int filled = 0;
                    while (i > leftMax)
                    {
                        filled += height[i];
                        i--;
                    }
                    int length = rightMin - leftMax - 1; // Bc we need value between.
                    result += (length * height[rightMin]) - filled; // Rect area - heights

                    pointer = rightMin;
                }
            }
            else
            {
                int filled = 0; // This is heights between our values.
                int i = pointer + 1;
                while (i < nextIndexes[pointer])
                {
                    filled += height[i];
                    i++;
                }

                int length = nextIndexes[pointer] - pointer - 1; // Bc we need value between.
                result += (length * height[pointer]) - filled; // Rect area - heights

                pointer = nextIndexes[pointer];
            }
        }

        return result;
    }

}


/*
----------------------------------FIRST ATTEMPT - WRONG----------------------------------

public class Solution {
    public int Trap(int[] height)
    {
        Stack<int> indexes = new(); // Monotonic stack with array indexes, we're searching for next bigger value.
        int result = 0;
        int topIndex = 0;

        for (int i = 0; i < height.Length; i++)
        {
            if (height[i] == 0) { continue; }
            if (indexes.Count == 0) { indexes.Push(i); continue; }

            if (height[indexes.Peek()] > height[i]) { indexes.Push(i); continue; }
            else
            {
                int filled = 0;
                while (indexes.Count != 1 && height[indexes.Peek()] <= height[i])
                {
                    filled += height[indexes.Pop()];
                }
                    
                int last = indexes.Pop();
                int length = i - last - 1; // We need levels between so -1.

                int lowerLevel = height[i] >= height[last] ? height[last] : height[i]; // Min level.
                int highestLevelIndex = height[i] > height[last] ? i : last; // Current max level.

                if (topIndex != highestLevelIndex && height[highestLevelIndex] != lowerLevel)
                {
                    if (topIndex == -1) { topIndex = highestLevelIndex; }

                    else if (height[topIndex] >= height[highestLevelIndex])
                    { result += (height[highestLevelIndex] - height[lowerLevel]) * highestLevelIndex - topIndex - 1; }

                    else if (height[topIndex] < height[highestLevelIndex]) 
                    { 
                        result += (height[topIndex] - height[lowerLevel]) * (highestLevelIndex - topIndex - 1);
                        topIndex = highestLevelIndex;
                    }
                }

                result += lowerLevel * length - filled;
                indexes.Push(i);
            }
        }

        return result;
    }

}
*/