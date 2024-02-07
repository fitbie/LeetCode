using System.Text;

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

        StringBuilder result = new();
        var sorted = pairs.OrderByDescending((kv) => kv.Value);
        foreach (var element in sorted)
        {
            var i = element.Value;
            while (i > 0)
            {
                result.Append(element.Key);
                i--;
            }
        }

        return result.ToString();
    }
}