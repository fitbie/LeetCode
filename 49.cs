// Solution solution = new();
// solution.GroupAnagrams(new string[] { "eat","tea","tan","ate","nat","bat", "", "" });

using System.Linq;

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        var result = new List<IList<string>>();

        if (strs.Length == 1)
        {
            result.Add(new List<string> { strs[0] });
            return result;
            // return new List<IList<string>>() { new List<string>() { strs[0] } };
        }
        
        Dictionary<string, List<string>> keyValues = new();

        for (int i = 0; i < strs.Length; i++)
        {
            var temp = string.Concat(strs[i].ToCharArray().OrderBy((c)=> c));

            if (!keyValues.ContainsKey(temp))
            {
                keyValues.Add(temp, new List<string>());
            }
            keyValues[temp].Add(strs[i]);
        }

        foreach (var value in keyValues.Values)
        {
            result.Add(value);
        }

        return result;
    }
}