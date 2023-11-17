public class Solution {
    public string LongestCommonPrefix(string[] strs) 
    {
        if (strs.Length == 1) { return strs[0]; }

        List<char[]> charsList = new List<char[]>();
        foreach (var s in strs)
        {
            charsList.Add(s.ToCharArray());
        }

        string result = "";

        int minLength = charsList[0].Length;
        foreach (var charArray in charsList)
        {
            minLength = minLength > charArray.Length ? charArray.Length : minLength;
        }

        for (int i = 0; i < minLength; i++ )
        {
            char c = charsList[0][i];
            foreach (var charArray in charsList)
            {
                if (charArray[i] != c) return result;
            }
            result += c;
        }

        return result;
    }
}