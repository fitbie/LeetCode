Solution solution = new();
solution.RotateString("abcde", "abced");


public class Solution 
{
    public bool RotateString(string s, string goal)
    {
        if (s.Length != goal.Length) return false;

        int remain = s.Length * 2;
        int gIndex = 0;
        int rightCount = 0;

        for (int sIndex = 0; remain > 0 && gIndex < goal.Length; sIndex = (sIndex + 1) % s.Length)
        {
            remain--;
            if (s[sIndex] == goal[gIndex])
            {
                gIndex++;
                rightCount++;
            }
            else if (remain < s.Length) return false;
        }

        return rightCount == goal.Length;
    }
}