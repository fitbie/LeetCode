// Solution solution = new();
// solution.GroupAnagrams(new string[] { "eat","tea","tan","ate","nat","bat", "", "" });


public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) 
    {
        var result = new List<IList<string>>();
        
        Dictionary<string, List<string>> keyValues = new();

        for (int i = 0; i < strs.Length; i++)
        {
            var temp = string.Concat(strs[i].OrderBy((c)=> c));

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