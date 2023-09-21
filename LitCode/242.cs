
bool solution = new Solution().IsAnagram("a", "aa");

public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) { return false; }

        Dictionary<char, int> chars = new Dictionary<char, int>();

        for (int i = 0; i < s.Length; i++)
        {
            chars.TryAdd(s[i], 0);
            chars.TryAdd(t[i], 0);

            chars[s[i]]--;
            chars[t[i]]++;
        }

        return (chars.Values.All((amount) => amount == 0));

    }
}

