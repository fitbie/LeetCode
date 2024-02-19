Solution solution = new();
solution.IsPowerOfTwo(16);

public class Solution {
    public bool IsPowerOfTwo(int n) 
    {
        int x = (int)MathF.Sqrt(n);
        x++;
        int y = 0;
        while (y <= x++)
        {
            if (1 << y == n) { return true; }
            y++;
        }

        return false;
    }
}