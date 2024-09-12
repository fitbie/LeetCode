public class Solution {
    public int CountConsistentStrings(string allowed, string[] words) 
    {
        HashSet<char> allowedSet = new(allowed);
        int result = 0;

        foreach (var word in words)
        {
            if (word.All(allowedSet.Contains))
            {
                result++;
            }
        }

        return result;
    }
}