Solution solution = new();
solution.FrequencySort("cccaaa");


public class Solution {
    public string FrequencySort(string s) 
    {
        Dictionary<char, int> pairs = new();

        for (int i = 0; i < s.Length; i++)
        {
            if (!pairs.ContainsKey(s[i]))
            {
                pairs.Add(s[i], 0);
            }

            pairs[s[i]]++;
        }

        string result = string.Empty;
        var sorted = pairs.OrderByDescending((kv) => kv);
        foreach (var element in sorted)
        {
            var i = element.Value;
            while (i > 0)
            {
                result += element.Key;
                i--;
            }
        }

        return result;
    }
}