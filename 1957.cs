using System.Text;

Solution solution = new();
solution.MakeFancyString("abbcccddddeeeee");

public class Solution {
    public string MakeFancyString(string s)
    {
        if (s.Length < 3) return s;

        StringBuilder sb = new(s.Length);
        sb.Append(s[0]);

        char lastChar = s[0];
        int counter = 1;

        for (int i = 1; i < s.Length; i++)
        {
            if (lastChar == s[i])
            {
                if (++counter != 3)
                {
                    sb.Append(s[i]);
                }
                else counter--;
            }
            else
            {
                lastChar = s[i];
                counter = 1;
                sb.Append(s[i]);
            }
        }

        return sb.ToString();
    }
}