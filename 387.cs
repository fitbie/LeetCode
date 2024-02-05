

Solution solution = new();
var res = solution.FirstUniqChar("babcadc");
Console.WriteLine(res);

public class Solution {
    public int FirstUniqChar(string s) 
    {
        Dictionary<char, List<int>> pairs = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (!pairs.ContainsKey(s[i])) { pairs.Add(s[i], new List<int>()); }
            pairs[s[i]].Add(i);
        }

        foreach (var i in pairs.Values)
        {
            if (i.Count == 1) 
            {
                return i[0];
            }
        }

        return -1;
    }
}

