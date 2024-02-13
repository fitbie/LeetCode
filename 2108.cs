public class Solution {
    public string FirstPalindrome(string[] words) 
    {
        string result = "";

        foreach (var s in words)
        {
            if (IsPalindrome(s)) { result = s; break; }
        }

        bool IsPalindrome(string s)
        {
            int l = 0;
            int r = s.Length - 1;

            while (l <= r)
            {
                if (s[l] != s[r]) { return false; }
                l++;
                r--;
            }

            return true;
        }

        return result;    
    }
}