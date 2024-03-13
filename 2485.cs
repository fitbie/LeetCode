Solution solution = new();
solution.PivotInteger(1);


public class Solution {
    public int PivotInteger(int n) 
    {
        int sum = (1 + n) / 2 * n;

        for (int i = n; i >= 1; i--)
        {
            if (Sum(0, i) == Sum(i, n)) { return i; }
        }

        int Sum(int start, int end)
        {
            int length = end - start + 1;
            return (int)((start + end) / 2d * length);
        }

        return -1;    
    }
}