Solution solution = new();
solution.GetLucky("leetcode", 2);

public class Solution {
    public int GetLucky(string s, int k) 
    {
        int sum = 0;

        IEnumerable<int> charDigids = s.Select(c => c - '`');
        string digids = string.Concat(charDigids);

        for (int i = 0; i < k; i++)
        {
            sum = 0;

            foreach (char c in digids)
            {
                sum += c - '0';
            }

            digids = sum.ToString();
        }


        return sum;
    }
}