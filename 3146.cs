public class Solution
{
    public int FindPermutationDifference(string s, string t)
    {
        Dictionary<char, int> sDict = new();
        Dictionary<char, int> tDict = new();
        for (int i = 0; i < s.Length; i++)
        {
            sDict.Add(s[i], i);
            tDict.Add(t[i], i);
        }

        return sDict.Select(kv => Math.Abs(kv.Value - tDict[kv.Key])).Sum();
    }
}